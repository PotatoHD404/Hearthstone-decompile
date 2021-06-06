using System.IO;
using bnet.protocol.account.v1;

namespace bnet.protocol.matchmaking.v1
{
	public class QueueExitNotification : IProtoBuf
	{
		public bool HasRequestId;

		private RequestId _RequestId;

		public bool HasCancelInitiator;

		private GameAccountHandle _CancelInitiator;

		public RequestId RequestId
		{
			get
			{
				return _RequestId;
			}
			set
			{
				_RequestId = value;
				HasRequestId = value != null;
			}
		}

		public GameAccountHandle CancelInitiator
		{
			get
			{
				return _CancelInitiator;
			}
			set
			{
				_CancelInitiator = value;
				HasCancelInitiator = value != null;
			}
		}

		public bool IsInitialized => true;

		public void SetRequestId(RequestId val)
		{
			RequestId = val;
		}

		public void SetCancelInitiator(GameAccountHandle val)
		{
			CancelInitiator = val;
		}

		public override int GetHashCode()
		{
			int num = GetType().GetHashCode();
			if (HasRequestId)
			{
				num ^= RequestId.GetHashCode();
			}
			if (HasCancelInitiator)
			{
				num ^= CancelInitiator.GetHashCode();
			}
			return num;
		}

		public override bool Equals(object obj)
		{
			QueueExitNotification queueExitNotification = obj as QueueExitNotification;
			if (queueExitNotification == null)
			{
				return false;
			}
			if (HasRequestId != queueExitNotification.HasRequestId || (HasRequestId && !RequestId.Equals(queueExitNotification.RequestId)))
			{
				return false;
			}
			if (HasCancelInitiator != queueExitNotification.HasCancelInitiator || (HasCancelInitiator && !CancelInitiator.Equals(queueExitNotification.CancelInitiator)))
			{
				return false;
			}
			return true;
		}

		public static QueueExitNotification ParseFrom(byte[] bs)
		{
			return ProtobufUtil.ParseFrom<QueueExitNotification>(bs);
		}

		public void Deserialize(Stream stream)
		{
			Deserialize(stream, this);
		}

		public static QueueExitNotification Deserialize(Stream stream, QueueExitNotification instance)
		{
			return Deserialize(stream, instance, -1L);
		}

		public static QueueExitNotification DeserializeLengthDelimited(Stream stream)
		{
			QueueExitNotification queueExitNotification = new QueueExitNotification();
			DeserializeLengthDelimited(stream, queueExitNotification);
			return queueExitNotification;
		}

		public static QueueExitNotification DeserializeLengthDelimited(Stream stream, QueueExitNotification instance)
		{
			long num = ProtocolParser.ReadUInt32(stream);
			num += stream.Position;
			return Deserialize(stream, instance, num);
		}

		public static QueueExitNotification Deserialize(Stream stream, QueueExitNotification instance, long limit)
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
					if (instance.RequestId == null)
					{
						instance.RequestId = RequestId.DeserializeLengthDelimited(stream);
					}
					else
					{
						RequestId.DeserializeLengthDelimited(stream, instance.RequestId);
					}
					continue;
				case 18:
					if (instance.CancelInitiator == null)
					{
						instance.CancelInitiator = GameAccountHandle.DeserializeLengthDelimited(stream);
					}
					else
					{
						GameAccountHandle.DeserializeLengthDelimited(stream, instance.CancelInitiator);
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

		public static void Serialize(Stream stream, QueueExitNotification instance)
		{
			if (instance.HasRequestId)
			{
				stream.WriteByte(10);
				ProtocolParser.WriteUInt32(stream, instance.RequestId.GetSerializedSize());
				RequestId.Serialize(stream, instance.RequestId);
			}
			if (instance.HasCancelInitiator)
			{
				stream.WriteByte(18);
				ProtocolParser.WriteUInt32(stream, instance.CancelInitiator.GetSerializedSize());
				GameAccountHandle.Serialize(stream, instance.CancelInitiator);
			}
		}

		public uint GetSerializedSize()
		{
			uint num = 0u;
			if (HasRequestId)
			{
				num++;
				uint serializedSize = RequestId.GetSerializedSize();
				num += serializedSize + ProtocolParser.SizeOfUInt32(serializedSize);
			}
			if (HasCancelInitiator)
			{
				num++;
				uint serializedSize2 = CancelInitiator.GetSerializedSize();
				num += serializedSize2 + ProtocolParser.SizeOfUInt32(serializedSize2);
			}
			return num;
		}
	}
}
