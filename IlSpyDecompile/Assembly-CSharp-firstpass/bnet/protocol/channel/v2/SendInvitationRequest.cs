using System.IO;
using bnet.protocol.account.v1;

namespace bnet.protocol.channel.v2
{
	public class SendInvitationRequest : IProtoBuf
	{
		public bool HasAgentId;

		private GameAccountHandle _AgentId;

		public bool HasOptions;

		private SendInvitationOptions _Options;

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

		public SendInvitationOptions Options
		{
			get
			{
				return _Options;
			}
			set
			{
				_Options = value;
				HasOptions = value != null;
			}
		}

		public bool IsInitialized => true;

		public void SetAgentId(GameAccountHandle val)
		{
			AgentId = val;
		}

		public void SetOptions(SendInvitationOptions val)
		{
			Options = val;
		}

		public override int GetHashCode()
		{
			int num = GetType().GetHashCode();
			if (HasAgentId)
			{
				num ^= AgentId.GetHashCode();
			}
			if (HasOptions)
			{
				num ^= Options.GetHashCode();
			}
			return num;
		}

		public override bool Equals(object obj)
		{
			SendInvitationRequest sendInvitationRequest = obj as SendInvitationRequest;
			if (sendInvitationRequest == null)
			{
				return false;
			}
			if (HasAgentId != sendInvitationRequest.HasAgentId || (HasAgentId && !AgentId.Equals(sendInvitationRequest.AgentId)))
			{
				return false;
			}
			if (HasOptions != sendInvitationRequest.HasOptions || (HasOptions && !Options.Equals(sendInvitationRequest.Options)))
			{
				return false;
			}
			return true;
		}

		public static SendInvitationRequest ParseFrom(byte[] bs)
		{
			return ProtobufUtil.ParseFrom<SendInvitationRequest>(bs);
		}

		public void Deserialize(Stream stream)
		{
			Deserialize(stream, this);
		}

		public static SendInvitationRequest Deserialize(Stream stream, SendInvitationRequest instance)
		{
			return Deserialize(stream, instance, -1L);
		}

		public static SendInvitationRequest DeserializeLengthDelimited(Stream stream)
		{
			SendInvitationRequest sendInvitationRequest = new SendInvitationRequest();
			DeserializeLengthDelimited(stream, sendInvitationRequest);
			return sendInvitationRequest;
		}

		public static SendInvitationRequest DeserializeLengthDelimited(Stream stream, SendInvitationRequest instance)
		{
			long num = ProtocolParser.ReadUInt32(stream);
			num += stream.Position;
			return Deserialize(stream, instance, num);
		}

		public static SendInvitationRequest Deserialize(Stream stream, SendInvitationRequest instance, long limit)
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
				case 18:
					if (instance.Options == null)
					{
						instance.Options = SendInvitationOptions.DeserializeLengthDelimited(stream);
					}
					else
					{
						SendInvitationOptions.DeserializeLengthDelimited(stream, instance.Options);
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

		public static void Serialize(Stream stream, SendInvitationRequest instance)
		{
			if (instance.HasAgentId)
			{
				stream.WriteByte(10);
				ProtocolParser.WriteUInt32(stream, instance.AgentId.GetSerializedSize());
				GameAccountHandle.Serialize(stream, instance.AgentId);
			}
			if (instance.HasOptions)
			{
				stream.WriteByte(18);
				ProtocolParser.WriteUInt32(stream, instance.Options.GetSerializedSize());
				SendInvitationOptions.Serialize(stream, instance.Options);
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
			if (HasOptions)
			{
				num++;
				uint serializedSize2 = Options.GetSerializedSize();
				num += serializedSize2 + ProtocolParser.SizeOfUInt32(serializedSize2);
			}
			return num;
		}
	}
}
