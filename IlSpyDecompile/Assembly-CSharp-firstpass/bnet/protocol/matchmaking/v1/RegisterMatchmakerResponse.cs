using System.IO;

namespace bnet.protocol.matchmaking.v1
{
	public class RegisterMatchmakerResponse : IProtoBuf
	{
		public bool HasMatchmakerGuid;

		private ulong _MatchmakerGuid;

		public ulong MatchmakerGuid
		{
			get
			{
				return _MatchmakerGuid;
			}
			set
			{
				_MatchmakerGuid = value;
				HasMatchmakerGuid = true;
			}
		}

		public bool IsInitialized => true;

		public void SetMatchmakerGuid(ulong val)
		{
			MatchmakerGuid = val;
		}

		public override int GetHashCode()
		{
			int num = GetType().GetHashCode();
			if (HasMatchmakerGuid)
			{
				num ^= MatchmakerGuid.GetHashCode();
			}
			return num;
		}

		public override bool Equals(object obj)
		{
			RegisterMatchmakerResponse registerMatchmakerResponse = obj as RegisterMatchmakerResponse;
			if (registerMatchmakerResponse == null)
			{
				return false;
			}
			if (HasMatchmakerGuid != registerMatchmakerResponse.HasMatchmakerGuid || (HasMatchmakerGuid && !MatchmakerGuid.Equals(registerMatchmakerResponse.MatchmakerGuid)))
			{
				return false;
			}
			return true;
		}

		public static RegisterMatchmakerResponse ParseFrom(byte[] bs)
		{
			return ProtobufUtil.ParseFrom<RegisterMatchmakerResponse>(bs);
		}

		public void Deserialize(Stream stream)
		{
			Deserialize(stream, this);
		}

		public static RegisterMatchmakerResponse Deserialize(Stream stream, RegisterMatchmakerResponse instance)
		{
			return Deserialize(stream, instance, -1L);
		}

		public static RegisterMatchmakerResponse DeserializeLengthDelimited(Stream stream)
		{
			RegisterMatchmakerResponse registerMatchmakerResponse = new RegisterMatchmakerResponse();
			DeserializeLengthDelimited(stream, registerMatchmakerResponse);
			return registerMatchmakerResponse;
		}

		public static RegisterMatchmakerResponse DeserializeLengthDelimited(Stream stream, RegisterMatchmakerResponse instance)
		{
			long num = ProtocolParser.ReadUInt32(stream);
			num += stream.Position;
			return Deserialize(stream, instance, num);
		}

		public static RegisterMatchmakerResponse Deserialize(Stream stream, RegisterMatchmakerResponse instance, long limit)
		{
			BinaryReader binaryReader = new BinaryReader(stream);
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
				case 9:
					instance.MatchmakerGuid = binaryReader.ReadUInt64();
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

		public static void Serialize(Stream stream, RegisterMatchmakerResponse instance)
		{
			BinaryWriter binaryWriter = new BinaryWriter(stream);
			if (instance.HasMatchmakerGuid)
			{
				stream.WriteByte(9);
				binaryWriter.Write(instance.MatchmakerGuid);
			}
		}

		public uint GetSerializedSize()
		{
			uint num = 0u;
			if (HasMatchmakerGuid)
			{
				num++;
				num += 8;
			}
			return num;
		}
	}
}
