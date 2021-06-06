using System;
using System.IO;

namespace bnet.protocol.friends.v1
{
	public class FriendNotification : IProtoBuf
	{
		public bool HasAccountId;

		private EntityId _AccountId;

		public bool HasForward;

		private ObjectAddress _Forward;

		public Friend Target { get; set; }

		public EntityId AccountId
		{
			get
			{
				return _AccountId;
			}
			set
			{
				_AccountId = value;
				HasAccountId = value != null;
			}
		}

		public ObjectAddress Forward
		{
			get
			{
				return _Forward;
			}
			set
			{
				_Forward = value;
				HasForward = value != null;
			}
		}

		public bool IsInitialized => true;

		public void SetTarget(Friend val)
		{
			Target = val;
		}

		public void SetAccountId(EntityId val)
		{
			AccountId = val;
		}

		public void SetForward(ObjectAddress val)
		{
			Forward = val;
		}

		public override int GetHashCode()
		{
			int hashCode = GetType().GetHashCode();
			hashCode ^= Target.GetHashCode();
			if (HasAccountId)
			{
				hashCode ^= AccountId.GetHashCode();
			}
			if (HasForward)
			{
				hashCode ^= Forward.GetHashCode();
			}
			return hashCode;
		}

		public override bool Equals(object obj)
		{
			FriendNotification friendNotification = obj as FriendNotification;
			if (friendNotification == null)
			{
				return false;
			}
			if (!Target.Equals(friendNotification.Target))
			{
				return false;
			}
			if (HasAccountId != friendNotification.HasAccountId || (HasAccountId && !AccountId.Equals(friendNotification.AccountId)))
			{
				return false;
			}
			if (HasForward != friendNotification.HasForward || (HasForward && !Forward.Equals(friendNotification.Forward)))
			{
				return false;
			}
			return true;
		}

		public static FriendNotification ParseFrom(byte[] bs)
		{
			return ProtobufUtil.ParseFrom<FriendNotification>(bs);
		}

		public void Deserialize(Stream stream)
		{
			Deserialize(stream, this);
		}

		public static FriendNotification Deserialize(Stream stream, FriendNotification instance)
		{
			return Deserialize(stream, instance, -1L);
		}

		public static FriendNotification DeserializeLengthDelimited(Stream stream)
		{
			FriendNotification friendNotification = new FriendNotification();
			DeserializeLengthDelimited(stream, friendNotification);
			return friendNotification;
		}

		public static FriendNotification DeserializeLengthDelimited(Stream stream, FriendNotification instance)
		{
			long num = ProtocolParser.ReadUInt32(stream);
			num += stream.Position;
			return Deserialize(stream, instance, num);
		}

		public static FriendNotification Deserialize(Stream stream, FriendNotification instance, long limit)
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
					if (instance.Target == null)
					{
						instance.Target = Friend.DeserializeLengthDelimited(stream);
					}
					else
					{
						Friend.DeserializeLengthDelimited(stream, instance.Target);
					}
					continue;
				case 42:
					if (instance.AccountId == null)
					{
						instance.AccountId = EntityId.DeserializeLengthDelimited(stream);
					}
					else
					{
						EntityId.DeserializeLengthDelimited(stream, instance.AccountId);
					}
					continue;
				case 50:
					if (instance.Forward == null)
					{
						instance.Forward = ObjectAddress.DeserializeLengthDelimited(stream);
					}
					else
					{
						ObjectAddress.DeserializeLengthDelimited(stream, instance.Forward);
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

		public static void Serialize(Stream stream, FriendNotification instance)
		{
			if (instance.Target == null)
			{
				throw new ArgumentNullException("Target", "Required by proto specification.");
			}
			stream.WriteByte(10);
			ProtocolParser.WriteUInt32(stream, instance.Target.GetSerializedSize());
			Friend.Serialize(stream, instance.Target);
			if (instance.HasAccountId)
			{
				stream.WriteByte(42);
				ProtocolParser.WriteUInt32(stream, instance.AccountId.GetSerializedSize());
				EntityId.Serialize(stream, instance.AccountId);
			}
			if (instance.HasForward)
			{
				stream.WriteByte(50);
				ProtocolParser.WriteUInt32(stream, instance.Forward.GetSerializedSize());
				ObjectAddress.Serialize(stream, instance.Forward);
			}
		}

		public uint GetSerializedSize()
		{
			uint num = 0u;
			uint serializedSize = Target.GetSerializedSize();
			num += serializedSize + ProtocolParser.SizeOfUInt32(serializedSize);
			if (HasAccountId)
			{
				num++;
				uint serializedSize2 = AccountId.GetSerializedSize();
				num += serializedSize2 + ProtocolParser.SizeOfUInt32(serializedSize2);
			}
			if (HasForward)
			{
				num++;
				uint serializedSize3 = Forward.GetSerializedSize();
				num += serializedSize3 + ProtocolParser.SizeOfUInt32(serializedSize3);
			}
			return num + 1;
		}
	}
}
