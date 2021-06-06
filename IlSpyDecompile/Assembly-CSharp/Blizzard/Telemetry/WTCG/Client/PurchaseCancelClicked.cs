using System.IO;

namespace Blizzard.Telemetry.WTCG.Client
{
	public class PurchaseCancelClicked : IProtoBuf
	{
		public bool HasPlayer;

		private Player _Player;

		public bool HasDeviceInfo;

		private DeviceInfo _DeviceInfo;

		public bool HasPmtProductId;

		private long _PmtProductId;

		public Player Player
		{
			get
			{
				return _Player;
			}
			set
			{
				_Player = value;
				HasPlayer = value != null;
			}
		}

		public DeviceInfo DeviceInfo
		{
			get
			{
				return _DeviceInfo;
			}
			set
			{
				_DeviceInfo = value;
				HasDeviceInfo = value != null;
			}
		}

		public long PmtProductId
		{
			get
			{
				return _PmtProductId;
			}
			set
			{
				_PmtProductId = value;
				HasPmtProductId = true;
			}
		}

		public override int GetHashCode()
		{
			int num = GetType().GetHashCode();
			if (HasPlayer)
			{
				num ^= Player.GetHashCode();
			}
			if (HasDeviceInfo)
			{
				num ^= DeviceInfo.GetHashCode();
			}
			if (HasPmtProductId)
			{
				num ^= PmtProductId.GetHashCode();
			}
			return num;
		}

		public override bool Equals(object obj)
		{
			PurchaseCancelClicked purchaseCancelClicked = obj as PurchaseCancelClicked;
			if (purchaseCancelClicked == null)
			{
				return false;
			}
			if (HasPlayer != purchaseCancelClicked.HasPlayer || (HasPlayer && !Player.Equals(purchaseCancelClicked.Player)))
			{
				return false;
			}
			if (HasDeviceInfo != purchaseCancelClicked.HasDeviceInfo || (HasDeviceInfo && !DeviceInfo.Equals(purchaseCancelClicked.DeviceInfo)))
			{
				return false;
			}
			if (HasPmtProductId != purchaseCancelClicked.HasPmtProductId || (HasPmtProductId && !PmtProductId.Equals(purchaseCancelClicked.PmtProductId)))
			{
				return false;
			}
			return true;
		}

		public void Deserialize(Stream stream)
		{
			Deserialize(stream, this);
		}

		public static PurchaseCancelClicked Deserialize(Stream stream, PurchaseCancelClicked instance)
		{
			return Deserialize(stream, instance, -1L);
		}

		public static PurchaseCancelClicked DeserializeLengthDelimited(Stream stream)
		{
			PurchaseCancelClicked purchaseCancelClicked = new PurchaseCancelClicked();
			DeserializeLengthDelimited(stream, purchaseCancelClicked);
			return purchaseCancelClicked;
		}

		public static PurchaseCancelClicked DeserializeLengthDelimited(Stream stream, PurchaseCancelClicked instance)
		{
			long num = ProtocolParser.ReadUInt32(stream);
			num += stream.Position;
			return Deserialize(stream, instance, num);
		}

		public static PurchaseCancelClicked Deserialize(Stream stream, PurchaseCancelClicked instance, long limit)
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
					if (instance.Player == null)
					{
						instance.Player = Player.DeserializeLengthDelimited(stream);
					}
					else
					{
						Player.DeserializeLengthDelimited(stream, instance.Player);
					}
					continue;
				case 18:
					if (instance.DeviceInfo == null)
					{
						instance.DeviceInfo = DeviceInfo.DeserializeLengthDelimited(stream);
					}
					else
					{
						DeviceInfo.DeserializeLengthDelimited(stream, instance.DeviceInfo);
					}
					continue;
				case 32:
					instance.PmtProductId = (long)ProtocolParser.ReadUInt64(stream);
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

		public static void Serialize(Stream stream, PurchaseCancelClicked instance)
		{
			if (instance.HasPlayer)
			{
				stream.WriteByte(10);
				ProtocolParser.WriteUInt32(stream, instance.Player.GetSerializedSize());
				Player.Serialize(stream, instance.Player);
			}
			if (instance.HasDeviceInfo)
			{
				stream.WriteByte(18);
				ProtocolParser.WriteUInt32(stream, instance.DeviceInfo.GetSerializedSize());
				DeviceInfo.Serialize(stream, instance.DeviceInfo);
			}
			if (instance.HasPmtProductId)
			{
				stream.WriteByte(32);
				ProtocolParser.WriteUInt64(stream, (ulong)instance.PmtProductId);
			}
		}

		public uint GetSerializedSize()
		{
			uint num = 0u;
			if (HasPlayer)
			{
				num++;
				uint serializedSize = Player.GetSerializedSize();
				num += serializedSize + ProtocolParser.SizeOfUInt32(serializedSize);
			}
			if (HasDeviceInfo)
			{
				num++;
				uint serializedSize2 = DeviceInfo.GetSerializedSize();
				num += serializedSize2 + ProtocolParser.SizeOfUInt32(serializedSize2);
			}
			if (HasPmtProductId)
			{
				num++;
				num += ProtocolParser.SizeOfUInt64((ulong)PmtProductId);
			}
			return num;
		}
	}
}
