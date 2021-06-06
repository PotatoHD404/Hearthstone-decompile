using System.IO;

namespace bnet.protocol.user_manager.v1
{
	public class ClearRecentPlayersRequest : IProtoBuf
	{
		public bool HasAgentId;

		private EntityId _AgentId;

		public bool HasProgram;

		private uint _Program;

		public EntityId AgentId
		{
			get
			{
				return _AgentId;
			}
			set
			{
				_AgentId = value;
				HasAgentId = value != null;
			}
		}

		public uint Program
		{
			get
			{
				return _Program;
			}
			set
			{
				_Program = value;
				HasProgram = true;
			}
		}

		public bool IsInitialized => true;

		public void SetAgentId(EntityId val)
		{
			AgentId = val;
		}

		public void SetProgram(uint val)
		{
			Program = val;
		}

		public override int GetHashCode()
		{
			int num = GetType().GetHashCode();
			if (HasAgentId)
			{
				num ^= AgentId.GetHashCode();
			}
			if (HasProgram)
			{
				num ^= Program.GetHashCode();
			}
			return num;
		}

		public override bool Equals(object obj)
		{
			ClearRecentPlayersRequest clearRecentPlayersRequest = obj as ClearRecentPlayersRequest;
			if (clearRecentPlayersRequest == null)
			{
				return false;
			}
			if (HasAgentId != clearRecentPlayersRequest.HasAgentId || (HasAgentId && !AgentId.Equals(clearRecentPlayersRequest.AgentId)))
			{
				return false;
			}
			if (HasProgram != clearRecentPlayersRequest.HasProgram || (HasProgram && !Program.Equals(clearRecentPlayersRequest.Program)))
			{
				return false;
			}
			return true;
		}

		public static ClearRecentPlayersRequest ParseFrom(byte[] bs)
		{
			return ProtobufUtil.ParseFrom<ClearRecentPlayersRequest>(bs);
		}

		public void Deserialize(Stream stream)
		{
			Deserialize(stream, this);
		}

		public static ClearRecentPlayersRequest Deserialize(Stream stream, ClearRecentPlayersRequest instance)
		{
			return Deserialize(stream, instance, -1L);
		}

		public static ClearRecentPlayersRequest DeserializeLengthDelimited(Stream stream)
		{
			ClearRecentPlayersRequest clearRecentPlayersRequest = new ClearRecentPlayersRequest();
			DeserializeLengthDelimited(stream, clearRecentPlayersRequest);
			return clearRecentPlayersRequest;
		}

		public static ClearRecentPlayersRequest DeserializeLengthDelimited(Stream stream, ClearRecentPlayersRequest instance)
		{
			long num = ProtocolParser.ReadUInt32(stream);
			num += stream.Position;
			return Deserialize(stream, instance, num);
		}

		public static ClearRecentPlayersRequest Deserialize(Stream stream, ClearRecentPlayersRequest instance, long limit)
		{
			while (true)
			{
				if (limit >= 0 && stream.Position >= limit)
				{
					if (stream.Position == limit)
					{
						break;
					}
					throw new ProtocolBufferException("Read past max limit");
				}
				int num = stream.ReadByte();
				switch (num)
				{
				case -1:
					break;
				case 10:
					if (instance.AgentId == null)
					{
						instance.AgentId = EntityId.DeserializeLengthDelimited(stream);
					}
					else
					{
						EntityId.DeserializeLengthDelimited(stream, instance.AgentId);
					}
					continue;
				case 16:
					instance.Program = ProtocolParser.ReadUInt32(stream);
					continue;
				default:
				{
					Key key = ProtocolParser.ReadKey((byte)num, stream);
					if (key.Field == 0)
					{
						throw new ProtocolBufferException("Invalid field id: 0, something went wrong in the stream");
					}
					ProtocolParser.SkipKey(stream, key);
					continue;
				}
				}
				if (limit < 0)
				{
					break;
				}
				throw new EndOfStreamException();
			}
			return instance;
		}

		public void Serialize(Stream stream)
		{
			Serialize(stream, this);
		}

		public static void Serialize(Stream stream, ClearRecentPlayersRequest instance)
		{
			if (instance.HasAgentId)
			{
				stream.WriteByte(10);
				ProtocolParser.WriteUInt32(stream, instance.AgentId.GetSerializedSize());
				EntityId.Serialize(stream, instance.AgentId);
			}
			if (instance.HasProgram)
			{
				stream.WriteByte(16);
				ProtocolParser.WriteUInt32(stream, instance.Program);
			}
		}

		public uint GetSerializedSize()
		{
			uint num = 0u;
			if (HasAgentId)
			{
				num++;
				uint serializedSize = AgentId.GetSerializedSize();
				num += serializedSize + ProtocolParser.SizeOfUInt32(serializedSize);
			}
			if (HasProgram)
			{
				num++;
				num += ProtocolParser.SizeOfUInt32(Program);
			}
			return num;
		}
	}
}
