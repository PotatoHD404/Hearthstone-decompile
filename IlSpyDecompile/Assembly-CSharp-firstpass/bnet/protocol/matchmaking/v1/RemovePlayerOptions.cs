using System.IO;
using bnet.protocol.account.v1;

namespace bnet.protocol.matchmaking.v1
{
	public class RemovePlayerOptions : IProtoBuf
	{
		public bool HasGameHandle;

		private GameHandle _GameHandle;

		public bool HasGameAccount;

		private GameAccountHandle _GameAccount;

		public GameHandle GameHandle
		{
			get
			{
				return _GameHandle;
			}
			set
			{
				_GameHandle = value;
				HasGameHandle = value != null;
			}
		}

		public GameAccountHandle GameAccount
		{
			get
			{
				return _GameAccount;
			}
			set
			{
				_GameAccount = value;
				HasGameAccount = value != null;
			}
		}

		public bool IsInitialized => true;

		public void SetGameHandle(GameHandle val)
		{
			GameHandle = val;
		}

		public void SetGameAccount(GameAccountHandle val)
		{
			GameAccount = val;
		}

		public override int GetHashCode()
		{
			int num = GetType().GetHashCode();
			if (HasGameHandle)
			{
				num ^= GameHandle.GetHashCode();
			}
			if (HasGameAccount)
			{
				num ^= GameAccount.GetHashCode();
			}
			return num;
		}

		public override bool Equals(object obj)
		{
			RemovePlayerOptions removePlayerOptions = obj as RemovePlayerOptions;
			if (removePlayerOptions == null)
			{
				return false;
			}
			if (HasGameHandle != removePlayerOptions.HasGameHandle || (HasGameHandle && !GameHandle.Equals(removePlayerOptions.GameHandle)))
			{
				return false;
			}
			if (HasGameAccount != removePlayerOptions.HasGameAccount || (HasGameAccount && !GameAccount.Equals(removePlayerOptions.GameAccount)))
			{
				return false;
			}
			return true;
		}

		public static RemovePlayerOptions ParseFrom(byte[] bs)
		{
			return ProtobufUtil.ParseFrom<RemovePlayerOptions>(bs);
		}

		public void Deserialize(Stream stream)
		{
			Deserialize(stream, this);
		}

		public static RemovePlayerOptions Deserialize(Stream stream, RemovePlayerOptions instance)
		{
			return Deserialize(stream, instance, -1L);
		}

		public static RemovePlayerOptions DeserializeLengthDelimited(Stream stream)
		{
			RemovePlayerOptions removePlayerOptions = new RemovePlayerOptions();
			DeserializeLengthDelimited(stream, removePlayerOptions);
			return removePlayerOptions;
		}

		public static RemovePlayerOptions DeserializeLengthDelimited(Stream stream, RemovePlayerOptions instance)
		{
			long num = ProtocolParser.ReadUInt32(stream);
			num += stream.Position;
			return Deserialize(stream, instance, num);
		}

		public static RemovePlayerOptions Deserialize(Stream stream, RemovePlayerOptions instance, long limit)
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
					if (instance.GameHandle == null)
					{
						instance.GameHandle = GameHandle.DeserializeLengthDelimited(stream);
					}
					else
					{
						GameHandle.DeserializeLengthDelimited(stream, instance.GameHandle);
					}
					continue;
				case 18:
					if (instance.GameAccount == null)
					{
						instance.GameAccount = GameAccountHandle.DeserializeLengthDelimited(stream);
					}
					else
					{
						GameAccountHandle.DeserializeLengthDelimited(stream, instance.GameAccount);
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

		public static void Serialize(Stream stream, RemovePlayerOptions instance)
		{
			if (instance.HasGameHandle)
			{
				stream.WriteByte(10);
				ProtocolParser.WriteUInt32(stream, instance.GameHandle.GetSerializedSize());
				GameHandle.Serialize(stream, instance.GameHandle);
			}
			if (instance.HasGameAccount)
			{
				stream.WriteByte(18);
				ProtocolParser.WriteUInt32(stream, instance.GameAccount.GetSerializedSize());
				GameAccountHandle.Serialize(stream, instance.GameAccount);
			}
		}

		public uint GetSerializedSize()
		{
			uint num = 0u;
			if (HasGameHandle)
			{
				num++;
				uint serializedSize = GameHandle.GetSerializedSize();
				num += serializedSize + ProtocolParser.SizeOfUInt32(serializedSize);
			}
			if (HasGameAccount)
			{
				num++;
				uint serializedSize2 = GameAccount.GetSerializedSize();
				num += serializedSize2 + ProtocolParser.SizeOfUInt32(serializedSize2);
			}
			return num;
		}
	}
}
