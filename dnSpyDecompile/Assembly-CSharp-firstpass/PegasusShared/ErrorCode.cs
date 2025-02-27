﻿using System;

namespace PegasusShared
{
	// Token: 0x02000178 RID: 376
	public enum ErrorCode
	{
		// Token: 0x0400087F RID: 2175
		ERROR_OK,
		// Token: 0x04000880 RID: 2176
		ERROR_HEARTHSTONE_BEGIN = 1000000,
		// Token: 0x04000881 RID: 2177
		ERROR_GLOBAL_INVALID_INPUT,
		// Token: 0x04000882 RID: 2178
		ERROR_GLOBAL_NO_DATA,
		// Token: 0x04000883 RID: 2179
		ERROR_GLOBAL_NOT_YET_IMPLEMENTED,
		// Token: 0x04000884 RID: 2180
		ERROR_GLOBAL_DATA_MODIFIED,
		// Token: 0x04000885 RID: 2181
		ERROR_GLOBAL_INTERNAL_DB_ERROR,
		// Token: 0x04000886 RID: 2182
		ERROR_GLOBAL_DECK_IS_LOCKED,
		// Token: 0x04000887 RID: 2183
		ERROR_GLOBAL_FEATURE_DISABLED,
		// Token: 0x04000888 RID: 2184
		ERROR_GLOBAL_HTTP_ERROR,
		// Token: 0x04000889 RID: 2185
		ERROR_GLOBAL_JSON_PARSE_ERROR,
		// Token: 0x0400088A RID: 2186
		ERROR_GLOBAL_INTERNAL_ERROR,
		// Token: 0x0400088B RID: 2187
		ERROR_GLOBAL_FSG_ID_INVALID,
		// Token: 0x0400088C RID: 2188
		ERROR_GLOBAL_HTTP_TIMEOUT_OR_ABORTED,
		// Token: 0x0400088D RID: 2189
		ERROR_GLOBAL_INVALID_HERO_SPECIFIED,
		// Token: 0x0400088E RID: 2190
		ERROR_GLOBAL_PARSE_ERROR_EXPECTED_NUMERIC_STRING,
		// Token: 0x0400088F RID: 2191
		ERROR_GLOBAL_BGS_FAILED,
		// Token: 0x04000890 RID: 2192
		ERROR_GLOBAL_DATABASE_FAILED,
		// Token: 0x04000891 RID: 2193
		ERROR_GLOBAL_UNKNOWN_PLAYER,
		// Token: 0x04000892 RID: 2194
		ERROR_SCENARIO_INCORRECT_NUM_PLAYERS = 1000500,
		// Token: 0x04000893 RID: 2195
		ERROR_SCENARIO_NO_DECK_SPECIFIED,
		// Token: 0x04000894 RID: 2196
		ERROR_SCENARIO_MUST_BE_SERVER_ONLY,
		// Token: 0x04000895 RID: 2197
		ERROR_TAVERN_BRAWL_SEASON_INCREMENTED = 1001000,
		// Token: 0x04000896 RID: 2198
		ERROR_TAVERN_BRAWL_NOT_ACTIVE,
		// Token: 0x04000897 RID: 2199
		ERROR_TAVERN_BRAWL_NO_TICKET,
		// Token: 0x04000898 RID: 2200
		ERROR_TAVERN_BRAWL_RETIRE_FIRST,
		// Token: 0x04000899 RID: 2201
		ERROR_TAVERN_BRAWL_NOT_IN_SESSION,
		// Token: 0x0400089A RID: 2202
		ERROR_TAVERN_BRAWL_NOT_IN_SESSION_BUT_COULD_BE,
		// Token: 0x0400089B RID: 2203
		ERROR_TAVERN_BRAWL_FEATURE_DISABLED,
		// Token: 0x0400089C RID: 2204
		ERROR_TAVERN_BRAWL_TICKET_NOT_REQUIRED,
		// Token: 0x0400089D RID: 2205
		ERROR_TAVERN_BRAWL_FRIENDLY_CHALLENGE_DISABLED,
		// Token: 0x0400089E RID: 2206
		ERROR_DECK_RULESET_RULE_UNKNOWN_TYPE = 1002000,
		// Token: 0x0400089F RID: 2207
		ERROR_DECK_RULESET_RULE_DB_READ_ERROR,
		// Token: 0x040008A0 RID: 2208
		ERROR_DECK_RULESET_RULE_VIOLATION,
		// Token: 0x040008A1 RID: 2209
		ERROR_DECK_RULESET_DECK_CARD_ID_UNKNOWN,
		// Token: 0x040008A2 RID: 2210
		ERROR_DECK_RULESET_HERO_CARD_GUID_UNKNOWN,
		// Token: 0x040008A3 RID: 2211
		ERROR_DECK_RULESET_DECK_CARD_GUID_UNKNOWN,
		// Token: 0x040008A4 RID: 2212
		ERROR_DECK_VALIDATION_DB_WRITE_ERROR,
		// Token: 0x040008A5 RID: 2213
		ERROR_DECK_VALIDATION_WRONG_FORMAT,
		// Token: 0x040008A6 RID: 2214
		ERROR_DECK_RULESET_MUST_BE_SERVER_ONLY,
		// Token: 0x040008A7 RID: 2215
		ERROR_DECK_VALIDATION_LEAGUE_BANNED_CARD,
		// Token: 0x040008A8 RID: 2216
		ERROR_DECK_RULESET_HERO_CARD_NOT_PLAYABLE,
		// Token: 0x040008A9 RID: 2217
		ERROR_PLAY_GAME_DECK_MODIFIED = 1003000,
		// Token: 0x040008AA RID: 2218
		ERROR_PLAY_GAME_FSG_ID_NOT_MATCHING = 1003002,
		// Token: 0x040008AB RID: 2219
		ERROR_PLAY_GAME_FSG_PATRON_NOT_CHECKED_IN,
		// Token: 0x040008AC RID: 2220
		ERROR_PLAY_GAME_FSG_NOT_CURRENTLY_PLAYABLE,
		// Token: 0x040008AD RID: 2221
		ERROR_PLAY_GAME_SEASON_INCREMENTED,
		// Token: 0x040008AE RID: 2222
		ERROR_PLAY_GAME_INCORRECT_NUM_PLAYERS,
		// Token: 0x040008AF RID: 2223
		ERROR_PLAY_GAME_INVALID_ATTRIBUTE,
		// Token: 0x040008B0 RID: 2224
		ERROR_PLAY_GAME_MISSING_ATTRIBUTE,
		// Token: 0x040008B1 RID: 2225
		ERROR_PLAY_GAME_INVALID_SCENARIO,
		// Token: 0x040008B2 RID: 2226
		ERROR_PLAY_GAME_INVALID_DECK,
		// Token: 0x040008B3 RID: 2227
		ERROR_PLAY_GAME_LEVEL_REQUIREMENT,
		// Token: 0x040008B4 RID: 2228
		ERROR_PLAY_GAME_INVALID_DECK_SHARING,
		// Token: 0x040008B5 RID: 2229
		ERROR_PLAY_GAME_CURRENTLY_IN_GAME,
		// Token: 0x040008B6 RID: 2230
		ERROR_PLAY_GAME_MISSING_LICENSE,
		// Token: 0x040008B7 RID: 2231
		ERROR_PLAY_GAME_PARTY_NOT_ALLOWED,
		// Token: 0x040008B8 RID: 2232
		ERROR_FSG_NO_PERMISSION = 1004000,
		// Token: 0x040008B9 RID: 2233
		ERROR_FSG_DUPLICATE_REQUEST_IGNORED,
		// Token: 0x040008BA RID: 2234
		ERROR_FSG_DUPLICATE_REQUEST_ORIGINAL_DROPPED,
		// Token: 0x040008BB RID: 2235
		ERROR_FSG_ALREADY_CHECKED_IN_FETCH_FSG_INFO,
		// Token: 0x040008BC RID: 2236
		ERROR_FSG_BSSIDS_NOT_VALID,
		// Token: 0x040008BD RID: 2237
		ERROR_GAME_SAVE_DATA_INVALID_KEY_REQUESTED = 1005000,
		// Token: 0x040008BE RID: 2238
		ERROR_SET_GAME_SAVE_DATA_INVALID_DATA,
		// Token: 0x040008BF RID: 2239
		ERROR_SET_GAME_SAVE_DATA_INVALID_SUBKEY,
		// Token: 0x040008C0 RID: 2240
		ERROR_SAVE_PROGRESS_RESTRICTED_NO_KEYS_UPDATED,
		// Token: 0x040008C1 RID: 2241
		ERROR_DUELS_NO_ACTIVE_SESSION = 1006000,
		// Token: 0x040008C2 RID: 2242
		ERROR_DUELS_SESSION_MISMATCH_REQUESTED_GAME
	}
}
