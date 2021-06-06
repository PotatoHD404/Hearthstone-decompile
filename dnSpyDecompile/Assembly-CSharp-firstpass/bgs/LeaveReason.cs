﻿using System;

namespace bgs
{
	// Token: 0x02000249 RID: 585
	public enum LeaveReason
	{
		// Token: 0x04000EF5 RID: 3829
		MEMBER_LEFT,
		// Token: 0x04000EF6 RID: 3830
		MEMBER_KICKED,
		// Token: 0x04000EF7 RID: 3831
		DISSOLVED_BY_MEMBER,
		// Token: 0x04000EF8 RID: 3832
		MEMBER_DISCONNECTED,
		// Token: 0x04000EF9 RID: 3833
		MEMBER_REMOVED_BY_SERVICE,
		// Token: 0x04000EFA RID: 3834
		DISSOLVED_BY_SERVICE,
		// Token: 0x04000EFB RID: 3835
		DISCONNECTED,
		// Token: 0x04000EFC RID: 3836
		UNKNOWN,
		// Token: 0x04000EFD RID: 3837
		PLAYER_REMOVED_BY_GAME_SERVER,
		// Token: 0x04000EFE RID: 3838
		GAME_ENDED_BY_GAME_SERVER,
		// Token: 0x04000EFF RID: 3839
		PLAYER_DISCONNECTED_FROM_GAME_SERVER,
		// Token: 0x04000F00 RID: 3840
		GAME_SERVER_DISCONNECTED_FROM_SERVICE,
		// Token: 0x04000F01 RID: 3841
		CHANNEL_HOST_DISCONNECTED_FROM_SERVICE,
		// Token: 0x04000F02 RID: 3842
		GAME_MASTER_DISCONNECTED_FROM_SERVICE,
		// Token: 0x04000F03 RID: 3843
		FOUNDER_LEFT
	}
}