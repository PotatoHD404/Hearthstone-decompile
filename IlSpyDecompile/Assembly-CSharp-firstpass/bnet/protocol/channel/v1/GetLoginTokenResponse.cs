using System.IO;

namespace bnet.protocol.channel.v1
{
	public class GetLoginTokenResponse : IProtoBuf
	{
		public bool HasCredentials;

		private VoiceCredentials _Credentials;

		public VoiceCredentials Credentials
		{
			get
			{
				return _Credentials;
			}
			set
			{
				_Credentials = value;
				HasCredentials = value != null;
			}
		}

		public bool IsInitialized => true;

		public void SetCredentials(VoiceCredentials val)
		{
			Credentials = val;
		}

		public override int GetHashCode()
		{
			int num = GetType().GetHashCode();
			if (HasCredentials)
			{
				num ^= Credentials.GetHashCode();
			}
			return num;
		}

		public override bool Equals(object obj)
		{
			GetLoginTokenResponse getLoginTokenResponse = obj as GetLoginTokenResponse;
			if (getLoginTokenResponse == null)
			{
				return false;
			}
			if (HasCredentials != getLoginTokenResponse.HasCredentials || (HasCredentials && !Credentials.Equals(getLoginTokenResponse.Credentials)))
			{
				return false;
			}
			return true;
		}

		public static GetLoginTokenResponse ParseFrom(byte[] bs)
		{
			return ProtobufUtil.ParseFrom<GetLoginTokenResponse>(bs);
		}

		public void Deserialize(Stream stream)
		{
			Deserialize(stream, this);
		}

		public static GetLoginTokenResponse Deserialize(Stream stream, GetLoginTokenResponse instance)
		{
			return Deserialize(stream, instance, -1L);
		}

		public static GetLoginTokenResponse DeserializeLengthDelimited(Stream stream)
		{
			GetLoginTokenResponse getLoginTokenResponse = new GetLoginTokenResponse();
			DeserializeLengthDelimited(stream, getLoginTokenResponse);
			return getLoginTokenResponse;
		}

		public static GetLoginTokenResponse DeserializeLengthDelimited(Stream stream, GetLoginTokenResponse instance)
		{
			long num = ProtocolParser.ReadUInt32(stream);
			num += stream.Position;
			return Deserialize(stream, instance, num);
		}

		public static GetLoginTokenResponse Deserialize(Stream stream, GetLoginTokenResponse instance, long limit)
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
					if (instance.Credentials == null)
					{
						instance.Credentials = VoiceCredentials.DeserializeLengthDelimited(stream);
					}
					else
					{
						VoiceCredentials.DeserializeLengthDelimited(stream, instance.Credentials);
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

		public static void Serialize(Stream stream, GetLoginTokenResponse instance)
		{
			if (instance.HasCredentials)
			{
				stream.WriteByte(10);
				ProtocolParser.WriteUInt32(stream, instance.Credentials.GetSerializedSize());
				VoiceCredentials.Serialize(stream, instance.Credentials);
			}
		}

		public uint GetSerializedSize()
		{
			uint num = 0u;
			if (HasCredentials)
			{
				num++;
				uint serializedSize = Credentials.GetSerializedSize();
				num += serializedSize + ProtocolParser.SizeOfUInt32(serializedSize);
			}
			return num;
		}
	}
}
