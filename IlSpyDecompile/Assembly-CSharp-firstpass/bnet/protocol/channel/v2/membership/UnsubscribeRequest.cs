using System.IO;
using bnet.protocol.account.v1;

namespace bnet.protocol.channel.v2.membership
{
	public class UnsubscribeRequest : IProtoBuf
	{
		public bool HasAgentId;

		private GameAccountHandle _AgentId;

		public GameAccountHandle AgentId
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

		public bool IsInitialized => true;

		public void SetAgentId(GameAccountHandle val)
		{
			AgentId = val;
		}

		public override int GetHashCode()
		{
			int num = GetType().GetHashCode();
			if (HasAgentId)
			{
				num ^= AgentId.GetHashCode();
			}
			return num;
		}

		public override bool Equals(object obj)
		{
			UnsubscribeRequest unsubscribeRequest = obj as UnsubscribeRequest;
			if (unsubscribeRequest == null)
			{
				return false;
			}
			if (HasAgentId != unsubscribeRequest.HasAgentId || (HasAgentId && !AgentId.Equals(unsubscribeRequest.AgentId)))
			{
				return false;
			}
			return true;
		}

		public static UnsubscribeRequest ParseFrom(byte[] bs)
		{
			return ProtobufUtil.ParseFrom<UnsubscribeRequest>(bs);
		}

		public void Deserialize(Stream stream)
		{
			Deserialize(stream, this);
		}

		public static UnsubscribeRequest Deserialize(Stream stream, UnsubscribeRequest instance)
		{
			return Deserialize(stream, instance, -1L);
		}

		public static UnsubscribeRequest DeserializeLengthDelimited(Stream stream)
		{
			UnsubscribeRequest unsubscribeRequest = new UnsubscribeRequest();
			DeserializeLengthDelimited(stream, unsubscribeRequest);
			return unsubscribeRequest;
		}

		public static UnsubscribeRequest DeserializeLengthDelimited(Stream stream, UnsubscribeRequest instance)
		{
			long num = ProtocolParser.ReadUInt32(stream);
			num += stream.Position;
			return Deserialize(stream, instance, num);
		}

		public static UnsubscribeRequest Deserialize(Stream stream, UnsubscribeRequest instance, long limit)
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
						instance.AgentId = GameAccountHandle.DeserializeLengthDelimited(stream);
					}
					else
					{
						GameAccountHandle.DeserializeLengthDelimited(stream, instance.AgentId);
					}
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

		public static void Serialize(Stream stream, UnsubscribeRequest instance)
		{
			if (instance.HasAgentId)
			{
				stream.WriteByte(10);
				ProtocolParser.WriteUInt32(stream, instance.AgentId.GetSerializedSize());
				GameAccountHandle.Serialize(stream, instance.AgentId);
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
			return num;
		}
	}
}
