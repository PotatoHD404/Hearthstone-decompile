﻿using System;

namespace PegasusShared
{
	// Token: 0x02000174 RID: 372
	public enum DeckType
	{
		// Token: 0x04000858 RID: 2136
		CLIENT_ONLY_DECK = -1,
		// Token: 0x04000859 RID: 2137
		UNKNOWN_DECK_TYPE,
		// Token: 0x0400085A RID: 2138
		NORMAL_DECK,
		// Token: 0x0400085B RID: 2139
		AI_DECK,
		// Token: 0x0400085C RID: 2140
		DRAFT_DECK = 4,
		// Token: 0x0400085D RID: 2141
		PRECON_DECK,
		// Token: 0x0400085E RID: 2142
		TAVERN_BRAWL_DECK,
		// Token: 0x0400085F RID: 2143
		FSG_BRAWL_DECK,
		// Token: 0x04000860 RID: 2144
		PVPDR_DECK,
		// Token: 0x04000861 RID: 2145
		PVPDR_DISPLAY_DECK,
		// Token: 0x04000862 RID: 2146
		HIDDEN_DECK = 1000
	}
}