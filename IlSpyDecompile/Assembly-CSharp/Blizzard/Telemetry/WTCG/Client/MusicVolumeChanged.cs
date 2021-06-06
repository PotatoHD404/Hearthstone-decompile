using System.IO;

namespace Blizzard.Telemetry.WTCG.Client
{
	public class MusicVolumeChanged : IProtoBuf
	{
		public bool HasPlayer;

		private Player _Player;

		public bool HasDeviceInfo;

		private DeviceInfo _DeviceInfo;

		public bool HasOldVolume;

		private float _OldVolume;

		public bool HasNewVolume;

		private float _NewVolume;

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

		public float OldVolume
		{
			get
			{
				return _OldVolume;
			}
			set
			{
				_OldVolume = value;
				HasOldVolume = true;
			}
		}

		public float NewVolume
		{
			get
			{
				return _NewVolume;
			}
			set
			{
				_NewVolume = value;
				HasNewVolume = true;
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
			if (HasOldVolume)
			{
				num ^= OldVolume.GetHashCode();
			}
			if (HasNewVolume)
			{
				num ^= NewVolume.GetHashCode();
			}
			return num;
		}

		public override bool Equals(object obj)
		{
			MusicVolumeChanged musicVolumeChanged = obj as MusicVolumeChanged;
			if (musicVolumeChanged == null)
			{
				return false;
			}
			if (HasPlayer != musicVolumeChanged.HasPlayer || (HasPlayer && !Player.Equals(musicVolumeChanged.Player)))
			{
				return false;
			}
			if (HasDeviceInfo != musicVolumeChanged.HasDeviceInfo || (HasDeviceInfo && !DeviceInfo.Equals(musicVolumeChanged.DeviceInfo)))
			{
				return false;
			}
			if (HasOldVolume != musicVolumeChanged.HasOldVolume || (HasOldVolume && !OldVolume.Equals(musicVolumeChanged.OldVolume)))
			{
				return false;
			}
			if (HasNewVolume != musicVolumeChanged.HasNewVolume || (HasNewVolume && !NewVolume.Equals(musicVolumeChanged.NewVolume)))
			{
				return false;
			}
			return true;
		}

		public void Deserialize(Stream stream)
		{
			Deserialize(stream, this);
		}

		public static MusicVolumeChanged Deserialize(Stream stream, MusicVolumeChanged instance)
		{
			return Deserialize(stream, instance, -1L);
		}

		public static MusicVolumeChanged DeserializeLengthDelimited(Stream stream)
		{
			MusicVolumeChanged musicVolumeChanged = new MusicVolumeChanged();
			DeserializeLengthDelimited(stream, musicVolumeChanged);
			return musicVolumeChanged;
		}

		public static MusicVolumeChanged DeserializeLengthDelimited(Stream stream, MusicVolumeChanged instance)
		{
			long num = ProtocolParser.ReadUInt32(stream);
			num += stream.Position;
			return Deserialize(stream, instance, num);
		}

		public static MusicVolumeChanged Deserialize(Stream stream, MusicVolumeChanged instance, long limit)
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
				case 37:
					instance.OldVolume = binaryReader.ReadSingle();
					continue;
				case 45:
					instance.NewVolume = binaryReader.ReadSingle();
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

		public static void Serialize(Stream stream, MusicVolumeChanged instance)
		{
			BinaryWriter binaryWriter = new BinaryWriter(stream);
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
			if (instance.HasOldVolume)
			{
				stream.WriteByte(37);
				binaryWriter.Write(instance.OldVolume);
			}
			if (instance.HasNewVolume)
			{
				stream.WriteByte(45);
				binaryWriter.Write(instance.NewVolume);
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
			if (HasOldVolume)
			{
				num++;
				num += 4;
			}
			if (HasNewVolume)
			{
				num++;
				num += 4;
			}
			return num;
		}
	}
}
