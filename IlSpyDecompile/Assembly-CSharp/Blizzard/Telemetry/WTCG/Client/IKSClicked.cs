using System.IO;
using System.Text;

namespace Blizzard.Telemetry.WTCG.Client
{
	public class IKSClicked : IProtoBuf
	{
		public bool HasPlayer;

		private Player _Player;

		public bool HasDeviceInfo;

		private DeviceInfo _DeviceInfo;

		public bool HasIksCampaignName;

		private string _IksCampaignName;

		public bool HasIksMediaUrl;

		private string _IksMediaUrl;

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

		public string IksCampaignName
		{
			get
			{
				return _IksCampaignName;
			}
			set
			{
				_IksCampaignName = value;
				HasIksCampaignName = value != null;
			}
		}

		public string IksMediaUrl
		{
			get
			{
				return _IksMediaUrl;
			}
			set
			{
				_IksMediaUrl = value;
				HasIksMediaUrl = value != null;
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
			if (HasIksCampaignName)
			{
				num ^= IksCampaignName.GetHashCode();
			}
			if (HasIksMediaUrl)
			{
				num ^= IksMediaUrl.GetHashCode();
			}
			return num;
		}

		public override bool Equals(object obj)
		{
			IKSClicked iKSClicked = obj as IKSClicked;
			if (iKSClicked == null)
			{
				return false;
			}
			if (HasPlayer != iKSClicked.HasPlayer || (HasPlayer && !Player.Equals(iKSClicked.Player)))
			{
				return false;
			}
			if (HasDeviceInfo != iKSClicked.HasDeviceInfo || (HasDeviceInfo && !DeviceInfo.Equals(iKSClicked.DeviceInfo)))
			{
				return false;
			}
			if (HasIksCampaignName != iKSClicked.HasIksCampaignName || (HasIksCampaignName && !IksCampaignName.Equals(iKSClicked.IksCampaignName)))
			{
				return false;
			}
			if (HasIksMediaUrl != iKSClicked.HasIksMediaUrl || (HasIksMediaUrl && !IksMediaUrl.Equals(iKSClicked.IksMediaUrl)))
			{
				return false;
			}
			return true;
		}

		public void Deserialize(Stream stream)
		{
			Deserialize(stream, this);
		}

		public static IKSClicked Deserialize(Stream stream, IKSClicked instance)
		{
			return Deserialize(stream, instance, -1L);
		}

		public static IKSClicked DeserializeLengthDelimited(Stream stream)
		{
			IKSClicked iKSClicked = new IKSClicked();
			DeserializeLengthDelimited(stream, iKSClicked);
			return iKSClicked;
		}

		public static IKSClicked DeserializeLengthDelimited(Stream stream, IKSClicked instance)
		{
			long num = ProtocolParser.ReadUInt32(stream);
			num += stream.Position;
			return Deserialize(stream, instance, num);
		}

		public static IKSClicked Deserialize(Stream stream, IKSClicked instance, long limit)
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
				case 26:
					instance.IksCampaignName = ProtocolParser.ReadString(stream);
					continue;
				case 34:
					instance.IksMediaUrl = ProtocolParser.ReadString(stream);
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

		public static void Serialize(Stream stream, IKSClicked instance)
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
			if (instance.HasIksCampaignName)
			{
				stream.WriteByte(26);
				ProtocolParser.WriteBytes(stream, Encoding.UTF8.GetBytes(instance.IksCampaignName));
			}
			if (instance.HasIksMediaUrl)
			{
				stream.WriteByte(34);
				ProtocolParser.WriteBytes(stream, Encoding.UTF8.GetBytes(instance.IksMediaUrl));
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
			if (HasIksCampaignName)
			{
				num++;
				uint byteCount = (uint)Encoding.UTF8.GetByteCount(IksCampaignName);
				num += ProtocolParser.SizeOfUInt32(byteCount) + byteCount;
			}
			if (HasIksMediaUrl)
			{
				num++;
				uint byteCount2 = (uint)Encoding.UTF8.GetByteCount(IksMediaUrl);
				num += ProtocolParser.SizeOfUInt32(byteCount2) + byteCount2;
			}
			return num;
		}
	}
}
