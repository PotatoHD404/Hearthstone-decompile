﻿using System;

namespace bnet.protocol.games.v1.Types
{
	// Token: 0x020003B4 RID: 948
	public enum GameEndedReason
	{
		// Token: 0x040015EC RID: 5612
		GAME_ENDED_REASON_DISSOLVED_BY_GAME_SERVER,
		// Token: 0x040015ED RID: 5613
		GAME_ENDED_REASON_DISSOLVED_BY_SERVICE,
		// Token: 0x040015EE RID: 5614
		GAME_ENDED_REASON_DISSOLVED_BY_PLAYER,
		// Token: 0x040015EF RID: 5615
		GAME_ENDED_REASON_DISSOLVED_BY_GAME_SERVER_DISCONNECT,
		// Token: 0x040015F0 RID: 5616
		GAME_ENDED_REASON_UNKNOWN,
		// Token: 0x040015F1 RID: 5617
		GAME_ENDED_REASON_GAME_MASTER_DISCONNECT
	}
}