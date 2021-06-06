using System.Collections.Generic;
using System.IO;

namespace bnet.protocol.friends.v2.client
{
	public class FriendAddedNotification : IProtoBuf
	{
		public bool HasAgentAccountId;

		private ulong _AgentAccountId;

		private List<Friend> _Friend = new List<Friend>();

		public ulong AgentAccountId
		{
			get
			{
				return _AgentAccountId;
			}
			set
			{
				_AgentAccountId = value;
				HasAgentAccountId = true;
			}
		}

		public List<Friend> Friend
		{
			get
			{
				return _Friend;
			}
			set
			{
				_Friend = value;
			}
		}

		public List<Friend> FriendList => _Friend;

		public int FriendCount => _Friend.Count;

		public bool IsInitialized => true;

		public void SetAgentAccountId(ulong val)
		{
			AgentAccountId = val;
		}

		public void AddFriend(Friend val)
		{
			_Friend.Add(val);
		}

		public void ClearFriend()
		{
			_Friend.Clear();
		}

		public void SetFriend(List<Friend> val)
		{
			Friend = val;
		}

		public override int GetHashCode()
		{
			int num = GetType().GetHashCode();
			if (HasAgentAccountId)
			{
				num ^= AgentAccountId.GetHashCode();
			}
			foreach (Friend item in Friend)
			{
				num ^= item.GetHashCode();
			}
			return num;
		}

		public override bool Equals(object obj)
		{
			FriendAddedNotification friendAddedNotification = obj as FriendAddedNotification;
			if (friendAddedNotification == null)
			{
				return false;
			}
			if (HasAgentAccountId != friendAddedNotification.HasAgentAccountId || (HasAgentAccountId && !AgentAccountId.Equals(friendAddedNotification.AgentAccountId)))
			{
				return false;
			}
			if (Friend.Count != friendAddedNotification.Friend.Count)
			{
				return false;
			}
			for (int i = 0; i < Friend.Count; i++)
			{
				if (!Friend[i].Equals(friendAddedNotification.Friend[i]))
				{
					return false;
				}
			}
			return true;
		}

		public static FriendAddedNotification ParseFrom(byte[] bs)
		{
			return ProtobufUtil.ParseFrom<FriendAddedNotification>(bs);
		}

		public void Deserialize(Stream stream)
		{
			Deserialize(stream, this);
		}

		public static FriendAddedNotification Deserialize(Stream stream, FriendAddedNotification instance)
		{
			return Deserialize(stream, instance, -1L);
		}

		public static FriendAddedNotification DeserializeLengthDelimited(Stream stream)
		{
			FriendAddedNotification friendAddedNotification = new FriendAddedNotification();
			DeserializeLengthDelimited(stream, friendAddedNotification);
			return friendAddedNotification;
		}

		public static FriendAddedNotification DeserializeLengthDelimited(Stream stream, FriendAddedNotification instance)
		{
			long num = ProtocolParser.ReadUInt32(stream);
			num += stream.Position;
			return Deserialize(stream, instance, num);
		}

		public static FriendAddedNotification Deserialize(Stream stream, FriendAddedNotification instance, long limit)
		{
			if (instance.Friend == null)
			{
				instance.Friend = new List<Friend>();
			}
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
				case 8:
					instance.AgentAccountId = ProtocolParser.ReadUInt64(stream);
					continue;
				case 18:
					instance.Friend.Add(bnet.protocol.friends.v2.client.Friend.DeserializeLengthDelimited(stream));
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

		public static void Serialize(Stream stream, FriendAddedNotification instance)
		{
			if (instance.HasAgentAccountId)
			{
				stream.WriteByte(8);
				ProtocolParser.WriteUInt64(stream, instance.AgentAccountId);
			}
			if (instance.Friend.Count <= 0)
			{
				return;
			}
			foreach (Friend item in instance.Friend)
			{
				stream.WriteByte(18);
				ProtocolParser.WriteUInt32(stream, item.GetSerializedSize());
				bnet.protocol.friends.v2.client.Friend.Serialize(stream, item);
			}
		}

		public uint GetSerializedSize()
		{
			uint num = 0u;
			if (HasAgentAccountId)
			{
				num++;
				num += ProtocolParser.SizeOfUInt64(AgentAccountId);
			}
			if (Friend.Count > 0)
			{
				foreach (Friend item in Friend)
				{
					num++;
					uint serializedSize = item.GetSerializedSize();
					num += serializedSize + ProtocolParser.SizeOfUInt32(serializedSize);
				}
				return num;
			}
			return num;
		}
	}
}
