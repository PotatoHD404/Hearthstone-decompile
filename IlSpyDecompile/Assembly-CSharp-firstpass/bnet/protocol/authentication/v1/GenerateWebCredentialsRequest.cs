using System.IO;

namespace bnet.protocol.authentication.v1
{
	public class GenerateWebCredentialsRequest : IProtoBuf
	{
		public bool HasProgram;

		private uint _Program;

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

		public void SetProgram(uint val)
		{
			Program = val;
		}

		public override int GetHashCode()
		{
			int num = GetType().GetHashCode();
			if (HasProgram)
			{
				num ^= Program.GetHashCode();
			}
			return num;
		}

		public override bool Equals(object obj)
		{
			GenerateWebCredentialsRequest generateWebCredentialsRequest = obj as GenerateWebCredentialsRequest;
			if (generateWebCredentialsRequest == null)
			{
				return false;
			}
			if (HasProgram != generateWebCredentialsRequest.HasProgram || (HasProgram && !Program.Equals(generateWebCredentialsRequest.Program)))
			{
				return false;
			}
			return true;
		}

		public static GenerateWebCredentialsRequest ParseFrom(byte[] bs)
		{
			return ProtobufUtil.ParseFrom<GenerateWebCredentialsRequest>(bs);
		}

		public void Deserialize(Stream stream)
		{
			Deserialize(stream, this);
		}

		public static GenerateWebCredentialsRequest Deserialize(Stream stream, GenerateWebCredentialsRequest instance)
		{
			return Deserialize(stream, instance, -1L);
		}

		public static GenerateWebCredentialsRequest DeserializeLengthDelimited(Stream stream)
		{
			GenerateWebCredentialsRequest generateWebCredentialsRequest = new GenerateWebCredentialsRequest();
			DeserializeLengthDelimited(stream, generateWebCredentialsRequest);
			return generateWebCredentialsRequest;
		}

		public static GenerateWebCredentialsRequest DeserializeLengthDelimited(Stream stream, GenerateWebCredentialsRequest instance)
		{
			long num = ProtocolParser.ReadUInt32(stream);
			num += stream.Position;
			return Deserialize(stream, instance, num);
		}

		public static GenerateWebCredentialsRequest Deserialize(Stream stream, GenerateWebCredentialsRequest instance, long limit)
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
				case 13:
					instance.Program = binaryReader.ReadUInt32();
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

		public static void Serialize(Stream stream, GenerateWebCredentialsRequest instance)
		{
			BinaryWriter binaryWriter = new BinaryWriter(stream);
			if (instance.HasProgram)
			{
				stream.WriteByte(13);
				binaryWriter.Write(instance.Program);
			}
		}

		public uint GetSerializedSize()
		{
			uint num = 0u;
			if (HasProgram)
			{
				num++;
				num += 4;
			}
			return num;
		}
	}
}
