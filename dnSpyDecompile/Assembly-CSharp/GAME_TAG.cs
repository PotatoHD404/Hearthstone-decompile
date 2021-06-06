﻿using System;

// Token: 0x02000914 RID: 2324
public enum GAME_TAG
{
	// Token: 0x040069DA RID: 27098
	TAG_NOT_SET,
	// Token: 0x040069DB RID: 27099
	TAG_SCRIPT_DATA_ENT_1 = 4,
	// Token: 0x040069DC RID: 27100
	TAG_SCRIPT_DATA_ENT_2,
	// Token: 0x040069DD RID: 27101
	TAG_SCRIPT_DATA_NUM_1 = 2,
	// Token: 0x040069DE RID: 27102
	TAG_SCRIPT_DATA_NUM_2,
	// Token: 0x040069DF RID: 27103
	TAG_TB_RANDOM_DECK_TIME_ID = 1358,
	// Token: 0x040069E0 RID: 27104
	STATE = 204,
	// Token: 0x040069E1 RID: 27105
	TURN = 20,
	// Token: 0x040069E2 RID: 27106
	STEP = 19,
	// Token: 0x040069E3 RID: 27107
	NEXT_STEP = 198,
	// Token: 0x040069E4 RID: 27108
	IS_CURRENT_TURN_AN_EXTRA_TURN = 547,
	// Token: 0x040069E5 RID: 27109
	EXTRA_TURNS_TAKEN_THIS_GAME,
	// Token: 0x040069E6 RID: 27110
	WAIT_FOR_PLAYER_RECONNECT_PERIOD = 860,
	// Token: 0x040069E7 RID: 27111
	PHASED_RESTART = 888,
	// Token: 0x040069E8 RID: 27112
	SQUELCH_NON_GAME_TRIGGERS_AND_MODIFIERS = 1087,
	// Token: 0x040069E9 RID: 27113
	SQUELCH_LIFETIME_EFFECTS = 1350,
	// Token: 0x040069EA RID: 27114
	BOARD_VISUAL_STATE = 1347,
	// Token: 0x040069EB RID: 27115
	ALLOW_MOVE_MINION = 1356,
	// Token: 0x040069EC RID: 27116
	CANT_MOVE_MINION = 1848,
	// Token: 0x040069ED RID: 27117
	BACON_USE_FAST_ANIMATIONS = 1402,
	// Token: 0x040069EE RID: 27118
	BACON_HIGHLIGHT_ATTACKING_MINION_DURING_COMBAT = 1424,
	// Token: 0x040069EF RID: 27119
	DISABLE_GOLDEN_ANIMATIONS = 1514,
	// Token: 0x040069F0 RID: 27120
	ALLOW_GAME_SPEEDUP = 1526,
	// Token: 0x040069F1 RID: 27121
	SKIP_MULLIGAN = 1561,
	// Token: 0x040069F2 RID: 27122
	DARKMOON_FAIRE_PRIZES_ACTIVE = 1895,
	// Token: 0x040069F3 RID: 27123
	TEAM_ID = 31,
	// Token: 0x040069F4 RID: 27124
	PLAYER_ID = 30,
	// Token: 0x040069F5 RID: 27125
	STARTHANDSIZE = 29,
	// Token: 0x040069F6 RID: 27126
	MAXHANDSIZE = 28,
	// Token: 0x040069F7 RID: 27127
	MAXRESOURCES = 176,
	// Token: 0x040069F8 RID: 27128
	TIMEOUT = 7,
	// Token: 0x040069F9 RID: 27129
	TURN_START,
	// Token: 0x040069FA RID: 27130
	TURN_TIMER_SLUSH,
	// Token: 0x040069FB RID: 27131
	HEROPOWER_ADDITIONAL_ACTIVATIONS = 405,
	// Token: 0x040069FC RID: 27132
	HEROPOWER_ACTIVATIONS_THIS_TURN,
	// Token: 0x040069FD RID: 27133
	BACON_DUMMY_PLAYER = 1349,
	// Token: 0x040069FE RID: 27134
	PROGRESSBAR_TOTAL = 1769,
	// Token: 0x040069FF RID: 27135
	PROGRESSBAR_PROGRESS,
	// Token: 0x04006A00 RID: 27136
	PROGRESSBAR_CARDID,
	// Token: 0x04006A01 RID: 27137
	PROGRESSBAR_SHOW,
	// Token: 0x04006A02 RID: 27138
	PROGRESSBAR_TEXT,
	// Token: 0x04006A03 RID: 27139
	GOLD_REWARD_STATE = 13,
	// Token: 0x04006A04 RID: 27140
	FIRST_PLAYER = 24,
	// Token: 0x04006A05 RID: 27141
	CURRENT_PLAYER = 23,
	// Token: 0x04006A06 RID: 27142
	HERO_ENTITY = 27,
	// Token: 0x04006A07 RID: 27143
	RESOURCES = 26,
	// Token: 0x04006A08 RID: 27144
	RESOURCES_USED = 25,
	// Token: 0x04006A09 RID: 27145
	FATIGUE = 22,
	// Token: 0x04006A0A RID: 27146
	PLAYSTATE = 17,
	// Token: 0x04006A0B RID: 27147
	CURRENT_SPELLPOWER = 291,
	// Token: 0x04006A0C RID: 27148
	CURRENT_SPELLPOWER_ARCANE = 1936,
	// Token: 0x04006A0D RID: 27149
	CURRENT_SPELLPOWER_FIRE,
	// Token: 0x04006A0E RID: 27150
	CURRENT_SPELLPOWER_FROST,
	// Token: 0x04006A0F RID: 27151
	CURRENT_SPELLPOWER_NATURE,
	// Token: 0x04006A10 RID: 27152
	CURRENT_SPELLPOWER_HOLY,
	// Token: 0x04006A11 RID: 27153
	CURRENT_SPELLPOWER_SHADOW,
	// Token: 0x04006A12 RID: 27154
	CURRENT_SPELLPOWER_FEL,
	// Token: 0x04006A13 RID: 27155
	CURRENT_SPELLPOWER_PHYSICAL,
	// Token: 0x04006A14 RID: 27156
	CURRENT_NEGATIVE_SPELLPOWER = 651,
	// Token: 0x04006A15 RID: 27157
	MULLIGAN_STATE = 305,
	// Token: 0x04006A16 RID: 27158
	ZONES_REVEALED = 348,
	// Token: 0x04006A17 RID: 27159
	STEADY_SHOT_CAN_TARGET = 383,
	// Token: 0x04006A18 RID: 27160
	OVERLOAD_THIS_GAME = 427,
	// Token: 0x04006A19 RID: 27161
	SPELLS_COST_HEALTH = 431,
	// Token: 0x04006A1A RID: 27162
	PROXY_CTHUN = 434,
	// Token: 0x04006A1B RID: 27163
	CANT_BE_FATIGUED = 456,
	// Token: 0x04006A1C RID: 27164
	RED_MANA_CRYSTALS = 449,
	// Token: 0x04006A1D RID: 27165
	WHIZBANG_DECK_ID = 1048,
	// Token: 0x04006A1E RID: 27166
	EXTRA_BATTLECRIES_BASE = 411,
	// Token: 0x04006A1F RID: 27167
	EXTRA_MINION_BATTLECRIES_BASE = 1112,
	// Token: 0x04006A20 RID: 27168
	EXTRA_BATTLECRIES_ADDITIONAL = 1126,
	// Token: 0x04006A21 RID: 27169
	EXTRA_DEATHRATTLES_BASE = 882,
	// Token: 0x04006A22 RID: 27170
	EXTRA_MINION_DEATHRATTLES_BASE = 371,
	// Token: 0x04006A23 RID: 27171
	EXTRA_DEATHRATTLES_ADDITIONAL = 1131,
	// Token: 0x04006A24 RID: 27172
	AMOUNT_HEALED_THIS_GAME = 958,
	// Token: 0x04006A25 RID: 27173
	NUM_HERO_POWER_DAMAGE_THIS_GAME = 1025,
	// Token: 0x04006A26 RID: 27174
	MARK_OF_EVIL = 994,
	// Token: 0x04006A27 RID: 27175
	HERO_FLYING = 1293,
	// Token: 0x04006A28 RID: 27176
	AI_MAKES_DECISIONS_FOR_PLAYER = 1335,
	// Token: 0x04006A29 RID: 27177
	DOUBLE_FATIGUE_DAMAGE = 1346,
	// Token: 0x04006A2A RID: 27178
	PLAYER_LEADERBOARD_PLACE = 1373,
	// Token: 0x04006A2B RID: 27179
	PLAYER_TECH_LEVEL = 1377,
	// Token: 0x04006A2C RID: 27180
	PLAYER_TRIPLES = 1447,
	// Token: 0x04006A2D RID: 27181
	NEXT_OPPONENT_PLAYER_ID = 1360,
	// Token: 0x04006A2E RID: 27182
	BACON_ODD_PLAYER_OUT = 1415,
	// Token: 0x04006A2F RID: 27183
	MAIN_GALAKROND = 1361,
	// Token: 0x04006A30 RID: 27184
	PROXY_GALAKROND = 1190,
	// Token: 0x04006A31 RID: 27185
	INVOKE_COUNTER = 1366,
	// Token: 0x04006A32 RID: 27186
	GALAKROND_HERO_CARD = 1365,
	// Token: 0x04006A33 RID: 27187
	BACON_HERO_POWER_ACTIVATED = 1398,
	// Token: 0x04006A34 RID: 27188
	PROXY_CTHUN_SHATTERED = 1768,
	// Token: 0x04006A35 RID: 27189
	PLAYED_CTHUN_EYE = 1764,
	// Token: 0x04006A36 RID: 27190
	PLAYED_CTHUN_BODY,
	// Token: 0x04006A37 RID: 27191
	PLAYED_CTHUN_MAW,
	// Token: 0x04006A38 RID: 27192
	PLAYED_CTHUN_HEART,
	// Token: 0x04006A39 RID: 27193
	NUM_SPELLS_PLAYED_THIS_GAME = 1780,
	// Token: 0x04006A3A RID: 27194
	CARDRACE = 200,
	// Token: 0x04006A3B RID: 27195
	CARDTYPE = 202,
	// Token: 0x04006A3C RID: 27196
	COST = 48,
	// Token: 0x04006A3D RID: 27197
	HEALTH = 45,
	// Token: 0x04006A3E RID: 27198
	ATK = 47,
	// Token: 0x04006A3F RID: 27199
	DURABILITY = 187,
	// Token: 0x04006A40 RID: 27200
	ARMOR = 292,
	// Token: 0x04006A41 RID: 27201
	PREDAMAGE = 318,
	// Token: 0x04006A42 RID: 27202
	PREHEALING = 425,
	// Token: 0x04006A43 RID: 27203
	TAG_LAST_KNOWN_COST_IN_HAND = 466,
	// Token: 0x04006A44 RID: 27204
	TARGETING_ARROW_TEXT = 325,
	// Token: 0x04006A45 RID: 27205
	LAST_AFFECTED_BY = 18,
	// Token: 0x04006A46 RID: 27206
	ENCHANTMENT_BIRTH_VISUAL = 330,
	// Token: 0x04006A47 RID: 27207
	ENCHANTMENT_IDLE_VISUAL,
	// Token: 0x04006A48 RID: 27208
	PREMIUM = 12,
	// Token: 0x04006A49 RID: 27209
	COLLECTIBLE = 321,
	// Token: 0x04006A4A RID: 27210
	CARDTEXT = 184,
	// Token: 0x04006A4B RID: 27211
	CUSTOMTEXT1 = 1093,
	// Token: 0x04006A4C RID: 27212
	CUSTOMTEXT2,
	// Token: 0x04006A4D RID: 27213
	CUSTOMTEXT3,
	// Token: 0x04006A4E RID: 27214
	DECK_LIST_SORT_ORDER = 1125,
	// Token: 0x04006A4F RID: 27215
	HERO_DECK_ID = 793,
	// Token: 0x04006A50 RID: 27216
	GAME_MODE_BUTTON_SLOT = 1438,
	// Token: 0x04006A51 RID: 27217
	TECH_LEVEL = 1440,
	// Token: 0x04006A52 RID: 27218
	MOVE_MINION_HOVER_TARGET_SLOT = 1464,
	// Token: 0x04006A53 RID: 27219
	BACON_ACTION_CARD = 1437,
	// Token: 0x04006A54 RID: 27220
	IS_BACON_POOL_MINION = 1456,
	// Token: 0x04006A55 RID: 27221
	BACON_HERO_CAN_BE_DRAFTED = 1491,
	// Token: 0x04006A56 RID: 27222
	SPAWN_TIME_COUNT = 1556,
	// Token: 0x04006A57 RID: 27223
	SPELL_SCHOOL = 1635,
	// Token: 0x04006A58 RID: 27224
	MINI_SET = 1824,
	// Token: 0x04006A59 RID: 27225
	HAS_DIAMOND_QUALITY = 1932,
	// Token: 0x04006A5A RID: 27226
	ENTITY_ID = 53,
	// Token: 0x04006A5B RID: 27227
	DEFINITION = 52,
	// Token: 0x04006A5C RID: 27228
	OWNER = 51,
	// Token: 0x04006A5D RID: 27229
	CONTROLLER = 50,
	// Token: 0x04006A5E RID: 27230
	ZONE = 49,
	// Token: 0x04006A5F RID: 27231
	EXHAUSTED = 43,
	// Token: 0x04006A60 RID: 27232
	ATTACHED = 40,
	// Token: 0x04006A61 RID: 27233
	PROPOSED_ATTACKER = 39,
	// Token: 0x04006A62 RID: 27234
	ATTACKING = 38,
	// Token: 0x04006A63 RID: 27235
	PROPOSED_DEFENDER = 37,
	// Token: 0x04006A64 RID: 27236
	DEFENDING = 36,
	// Token: 0x04006A65 RID: 27237
	PROTECTED = 35,
	// Token: 0x04006A66 RID: 27238
	PROTECTING = 34,
	// Token: 0x04006A67 RID: 27239
	RECENTLY_ARRIVED = 33,
	// Token: 0x04006A68 RID: 27240
	DAMAGE = 44,
	// Token: 0x04006A69 RID: 27241
	DATABASE_ID = 327,
	// Token: 0x04006A6A RID: 27242
	MODULAR_ENTITY_PART_1 = 471,
	// Token: 0x04006A6B RID: 27243
	MODULAR_ENTITY_PART_2,
	// Token: 0x04006A6C RID: 27244
	QUEST_PROGRESS = 534,
	// Token: 0x04006A6D RID: 27245
	QUEST_PROGRESS_TOTAL,
	// Token: 0x04006A6E RID: 27246
	QUEST_CONTRIBUTOR = 541,
	// Token: 0x04006A6F RID: 27247
	QUEST_REWARD_DATABASE_ID = 1089,
	// Token: 0x04006A70 RID: 27248
	SHIFTING = 438,
	// Token: 0x04006A71 RID: 27249
	SHIFTING_MINION = 549,
	// Token: 0x04006A72 RID: 27250
	SHIFTING_WEAPON,
	// Token: 0x04006A73 RID: 27251
	SHIFTING_SPELL = 936,
	// Token: 0x04006A74 RID: 27252
	TREASURE = 557,
	// Token: 0x04006A75 RID: 27253
	TREASURE_DEFINTIONAL_ATTACK,
	// Token: 0x04006A76 RID: 27254
	TREASURE_DEFINTIONAL_COST,
	// Token: 0x04006A77 RID: 27255
	TREASURE_DEFINTIONAL_HEALTH,
	// Token: 0x04006A78 RID: 27256
	ACTS_LIKE_A_SPELL,
	// Token: 0x04006A79 RID: 27257
	EMPOWERED_TREASURE = 646,
	// Token: 0x04006A7A RID: 27258
	ONE_SIDED_GHOSTLY = 648,
	// Token: 0x04006A7B RID: 27259
	OPPONENT_SIDE_GHOSTLY = 1609,
	// Token: 0x04006A7C RID: 27260
	IS_VAMPIRE = 680,
	// Token: 0x04006A7D RID: 27261
	VALEERASHADOW = 779,
	// Token: 0x04006A7E RID: 27262
	RECRUIT = 763,
	// Token: 0x04006A7F RID: 27263
	LOOT_CARD_1,
	// Token: 0x04006A80 RID: 27264
	LOOT_CARD_2,
	// Token: 0x04006A81 RID: 27265
	LOOT_CARD_3,
	// Token: 0x04006A82 RID: 27266
	OVERRIDECARDNAME = 781,
	// Token: 0x04006A83 RID: 27267
	OVERRIDECARDTEXTBUILDER,
	// Token: 0x04006A84 RID: 27268
	USE_ALTERNATE_CARD_TEXT = 955,
	// Token: 0x04006A85 RID: 27269
	TREAT_AS_PLAYED_HERO_CARD = 1016,
	// Token: 0x04006A86 RID: 27270
	FLOOPY = 1097,
	// Token: 0x04006A87 RID: 27271
	PLAYER_TAG_THRESHOLD_TAG_ID = 1115,
	// Token: 0x04006A88 RID: 27272
	PLAYER_TAG_THRESHOLD_VALUE,
	// Token: 0x04006A89 RID: 27273
	HIDE_WATERMARK = 1107,
	// Token: 0x04006A8A RID: 27274
	WATERMARK_OVERRIDE_CARD_SET = 1517,
	// Token: 0x04006A8B RID: 27275
	COPIED_BY_KHADGAR = 1326,
	// Token: 0x04006A8C RID: 27276
	COLLECTION_RELATED_CARD_DATABASE_ID = 1452,
	// Token: 0x04006A8D RID: 27277
	COPIED_FROM_ENTITY_ID = 1565,
	// Token: 0x04006A8E RID: 27278
	USE_LEADERBOARD_AS_SPAWN_ORIGIN = 1628,
	// Token: 0x04006A8F RID: 27279
	BACON_MUKLA_BANANA_SPAWN_COUNT,
	// Token: 0x04006A90 RID: 27280
	TRANSFORMED_FROM_CARD_VISUAL_TYPE = 1719,
	// Token: 0x04006A91 RID: 27281
	PIECE_OF_CTHUN = 1477,
	// Token: 0x04006A92 RID: 27282
	DARKMOON_TICKET = 1776,
	// Token: 0x04006A93 RID: 27283
	SHOW_DISCOVER_FROM_DECK = 1816,
	// Token: 0x04006A94 RID: 27284
	TRIGGER_VISUAL = 32,
	// Token: 0x04006A95 RID: 27285
	TAG_ONE_TURN_EFFECT = 338,
	// Token: 0x04006A96 RID: 27286
	TAUNT = 190,
	// Token: 0x04006A97 RID: 27287
	SPELLPOWER = 192,
	// Token: 0x04006A98 RID: 27288
	SPELLPOWER_ARCANE = 1945,
	// Token: 0x04006A99 RID: 27289
	SPELLPOWER_FIRE,
	// Token: 0x04006A9A RID: 27290
	SPELLPOWER_FROST,
	// Token: 0x04006A9B RID: 27291
	SPELLPOWER_NATURE,
	// Token: 0x04006A9C RID: 27292
	SPELLPOWER_HOLY,
	// Token: 0x04006A9D RID: 27293
	SPELLPOWER_SHADOW,
	// Token: 0x04006A9E RID: 27294
	SPELLPOWER_FEL,
	// Token: 0x04006A9F RID: 27295
	SPELLPOWER_PHYSICAL,
	// Token: 0x04006AA0 RID: 27296
	DIVINE_SHIELD = 194,
	// Token: 0x04006AA1 RID: 27297
	CHARGE = 197,
	// Token: 0x04006AA2 RID: 27298
	SECRET = 219,
	// Token: 0x04006AA3 RID: 27299
	MORPH = 293,
	// Token: 0x04006AA4 RID: 27300
	TAUNT_READY = 306,
	// Token: 0x04006AA5 RID: 27301
	IGNORE_TAUNT = 433,
	// Token: 0x04006AA6 RID: 27302
	STEALTH_READY = 307,
	// Token: 0x04006AA7 RID: 27303
	CHARGE_READY,
	// Token: 0x04006AA8 RID: 27304
	CREATOR = 313,
	// Token: 0x04006AA9 RID: 27305
	CREATOR_DBID = 1284,
	// Token: 0x04006AAA RID: 27306
	START_OF_GAME = 968,
	// Token: 0x04006AAB RID: 27307
	HEALING_DOES_DAMAGE_HINT = 1117,
	// Token: 0x04006AAC RID: 27308
	LIFESTEAL_DOES_DAMAGE_HINT = 1774,
	// Token: 0x04006AAD RID: 27309
	AFFECTED_BY_HEALING_DOES_DAMAGE = 1118,
	// Token: 0x04006AAE RID: 27310
	RULEBOOK = 1430,
	// Token: 0x04006AAF RID: 27311
	CANT_DRAW = 232,
	// Token: 0x04006AB0 RID: 27312
	CANT_PLAY = 231,
	// Token: 0x04006AB1 RID: 27313
	CANT_DISCARD = 230,
	// Token: 0x04006AB2 RID: 27314
	CANT_ATTACK = 227,
	// Token: 0x04006AB3 RID: 27315
	CANT_READY = 225,
	// Token: 0x04006AB4 RID: 27316
	CANT_REMOVE_FROM_GAME = 224,
	// Token: 0x04006AB5 RID: 27317
	CANT_SET_ASIDE = 223,
	// Token: 0x04006AB6 RID: 27318
	CANT_DAMAGE = 222,
	// Token: 0x04006AB7 RID: 27319
	CANT_HEAL = 221,
	// Token: 0x04006AB8 RID: 27320
	CANT_TRIGGER_DEATHRATTLE = 1831,
	// Token: 0x04006AB9 RID: 27321
	CANT_BE_DESTROYED = 247,
	// Token: 0x04006ABA RID: 27322
	CANT_BE_TARGETED = 246,
	// Token: 0x04006ABB RID: 27323
	CANT_BE_ATTACKED = 245,
	// Token: 0x04006ABC RID: 27324
	CANT_BE_READIED = 243,
	// Token: 0x04006ABD RID: 27325
	CANT_BE_REMOVED_FROM_GAME = 242,
	// Token: 0x04006ABE RID: 27326
	CANT_BE_SET_ASIDE = 241,
	// Token: 0x04006ABF RID: 27327
	IMMUNE = 240,
	// Token: 0x04006AC0 RID: 27328
	CANT_BE_HEALED = 239,
	// Token: 0x04006AC1 RID: 27329
	CANT_BE_SUMMONING_SICK = 253,
	// Token: 0x04006AC2 RID: 27330
	CANT_BE_SILENCED = 314,
	// Token: 0x04006AC3 RID: 27331
	APPEAR_FUNCTIONALLY_DEAD = 426,
	// Token: 0x04006AC4 RID: 27332
	FROZEN = 260,
	// Token: 0x04006AC5 RID: 27333
	JUST_PLAYED,
	// Token: 0x04006AC6 RID: 27334
	LINKED_ENTITY,
	// Token: 0x04006AC7 RID: 27335
	ZONE_POSITION,
	// Token: 0x04006AC8 RID: 27336
	CANT_BE_FROZEN,
	// Token: 0x04006AC9 RID: 27337
	COMBO_ACTIVE = 266,
	// Token: 0x04006ACA RID: 27338
	CARD_TARGET,
	// Token: 0x04006ACB RID: 27339
	NUM_CARDS_PLAYED_THIS_TURN = 269,
	// Token: 0x04006ACC RID: 27340
	CANT_BE_TARGETED_BY_OPPONENTS,
	// Token: 0x04006ACD RID: 27341
	NUM_TURNS_IN_PLAY,
	// Token: 0x04006ACE RID: 27342
	NUM_TURNS_IN_HAND = 273,
	// Token: 0x04006ACF RID: 27343
	SUMMONED = 205,
	// Token: 0x04006AD0 RID: 27344
	ENRAGED = 212,
	// Token: 0x04006AD1 RID: 27345
	ENRAGED_TOOLTIP = 1954,
	// Token: 0x04006AD2 RID: 27346
	SILENCED = 188,
	// Token: 0x04006AD3 RID: 27347
	WINDFURY,
	// Token: 0x04006AD4 RID: 27348
	MEGA_WINDFURY = 1207,
	// Token: 0x04006AD5 RID: 27349
	LOYALTY = 216,
	// Token: 0x04006AD6 RID: 27350
	DEATHRATTLE,
	// Token: 0x04006AD7 RID: 27351
	ADJACENT_BUFF = 350,
	// Token: 0x04006AD8 RID: 27352
	STEALTH = 191,
	// Token: 0x04006AD9 RID: 27353
	BATTLECRY = 218,
	// Token: 0x04006ADA RID: 27354
	NUM_TURNS_LEFT = 272,
	// Token: 0x04006ADB RID: 27355
	IS_MORPHED = 294,
	// Token: 0x04006ADC RID: 27356
	TEMP_RESOURCES,
	// Token: 0x04006ADD RID: 27357
	OVERLOAD_OWED,
	// Token: 0x04006ADE RID: 27358
	NUM_ATTACKS_THIS_TURN,
	// Token: 0x04006ADF RID: 27359
	NEXT_ALLY_BUFF = 302,
	// Token: 0x04006AE0 RID: 27360
	MAGNET,
	// Token: 0x04006AE1 RID: 27361
	FIRST_CARD_PLAYED_THIS_TURN,
	// Token: 0x04006AE2 RID: 27362
	CANT_BE_TARGETED_BY_SPELLS = 311,
	// Token: 0x04006AE3 RID: 27363
	SHOULDEXITCOMBAT,
	// Token: 0x04006AE4 RID: 27364
	PARENT_CARD = 316,
	// Token: 0x04006AE5 RID: 27365
	NUM_MINIONS_PLAYED_THIS_TURN,
	// Token: 0x04006AE6 RID: 27366
	CANT_BE_TARGETED_BY_HERO_POWERS = 332,
	// Token: 0x04006AE7 RID: 27367
	CANT_BE_TARGETED_BY_BATTLECRIES = 379,
	// Token: 0x04006AE8 RID: 27368
	CANNOT_ATTACK_HEROES = 413,
	// Token: 0x04006AE9 RID: 27369
	UNTOUCHABLE = 448,
	// Token: 0x04006AEA RID: 27370
	QUEST = 462,
	// Token: 0x04006AEB RID: 27371
	SIDEQUEST = 1192,
	// Token: 0x04006AEC RID: 27372
	SIGIL = 1749,
	// Token: 0x04006AED RID: 27373
	FINISH_ATTACK_SPELL_ON_DAMAGE = 470,
	// Token: 0x04006AEE RID: 27374
	ADAPT = 546,
	// Token: 0x04006AEF RID: 27375
	GEARS = 1052,
	// Token: 0x04006AF0 RID: 27376
	GOOD_OL_GENERIC_FRIENDLY_DRAGON_DISCOVER_VISUALS = 1364,
	// Token: 0x04006AF1 RID: 27377
	DISCOVER_STUDIES_VISUAL = 1650,
	// Token: 0x04006AF2 RID: 27378
	DUNGEON_PASSIVE_BUFF = 783,
	// Token: 0x04006AF3 RID: 27379
	HEALING_DOES_DAMAGE = 326,
	// Token: 0x04006AF4 RID: 27380
	ALTERNATE_CHAPTER_VO = 1334,
	// Token: 0x04006AF5 RID: 27381
	LIFESTEAL_DAMAGES_OPPOSING_HERO = 1675,
	// Token: 0x04006AF6 RID: 27382
	SCORE_LABELID_1 = 450,
	// Token: 0x04006AF7 RID: 27383
	SCORE_LABELID_2 = 452,
	// Token: 0x04006AF8 RID: 27384
	SCORE_LABELID_3 = 454,
	// Token: 0x04006AF9 RID: 27385
	SCORE_VALUE_1 = 451,
	// Token: 0x04006AFA RID: 27386
	SCORE_VALUE_2 = 453,
	// Token: 0x04006AFB RID: 27387
	SCORE_VALUE_3 = 455,
	// Token: 0x04006AFC RID: 27388
	SCORE_FOOTERID = 751,
	// Token: 0x04006AFD RID: 27389
	ZOMBEAST_DEBUG_CURRENT_BEAST_DATABASE_ID = 964,
	// Token: 0x04006AFE RID: 27390
	ZOMBEAST_DEBUG_CURRENT_ITERATION,
	// Token: 0x04006AFF RID: 27391
	ZOMBEAST_DEBUG_MAX_ITERATIONS,
	// Token: 0x04006B00 RID: 27392
	DRUSTVAR_HORROR_DEBUG_CURRENT_SPELL_DATABASE_ID = 1280,
	// Token: 0x04006B01 RID: 27393
	DRUSTVAR_HORROR_DEBUG_CURRENT_ITERATION,
	// Token: 0x04006B02 RID: 27394
	DRUSTVAR_HORROR_DEBUG_MAX_ITERATIONS = 1283,
	// Token: 0x04006B03 RID: 27395
	DEBUG_DISPLAY_TAG_BOTTOM_RIGHT = 1313,
	// Token: 0x04006B04 RID: 27396
	DEBUG_DISPLAY_TAG_TOP_RIGHT,
	// Token: 0x04006B05 RID: 27397
	SMART_DISCOVER_DEBUG_ENTITY_1 = 1318,
	// Token: 0x04006B06 RID: 27398
	SMART_DISCOVER_DEBUG_ENTITY_2,
	// Token: 0x04006B07 RID: 27399
	SMART_DISCOVER_DEBUG_ENTITY_3,
	// Token: 0x04006B08 RID: 27400
	SMART_DISCOVER_DEBUG_TEST_COMPLETE = 1324,
	// Token: 0x04006B09 RID: 27401
	SMART_DISCOVER_DEBUG_PASSIVE_EVAL_RESULT_1 = 1328,
	// Token: 0x04006B0A RID: 27402
	SMART_DISCOVER_DEBUG_PASSIVE_EVAL_RESULT_2,
	// Token: 0x04006B0B RID: 27403
	SMART_DISCOVER_DEBUG_PASSIVE_EVAL_RESULT_3,
	// Token: 0x04006B0C RID: 27404
	CHOICE_NAME_DISPLAY_TYPE = 1687,
	// Token: 0x04006B0D RID: 27405
	CHOICE_ACTOR_TYPE = 1692,
	// Token: 0x04006B0E RID: 27406
	COMBO = 220,
	// Token: 0x04006B0F RID: 27407
	ELITE = 114,
	// Token: 0x04006B10 RID: 27408
	CARD_SET = 183,
	// Token: 0x04006B11 RID: 27409
	FACTION = 201,
	// Token: 0x04006B12 RID: 27410
	RARITY = 203,
	// Token: 0x04006B13 RID: 27411
	CLASS = 199,
	// Token: 0x04006B14 RID: 27412
	MISSION_EVENT = 6,
	// Token: 0x04006B15 RID: 27413
	FREEZE = 208,
	// Token: 0x04006B16 RID: 27414
	OVERLOAD = 215,
	// Token: 0x04006B17 RID: 27415
	SILENCE = 339,
	// Token: 0x04006B18 RID: 27416
	COUNTER,
	// Token: 0x04006B19 RID: 27417
	FORCED_PLAY = 352,
	// Token: 0x04006B1A RID: 27418
	LOW_HEALTH_THRESHOLD,
	// Token: 0x04006B1B RID: 27419
	SPELLPOWER_DOUBLE = 356,
	// Token: 0x04006B1C RID: 27420
	SPELL_HEALING_DOUBLE,
	// Token: 0x04006B1D RID: 27421
	ALL_HEALING_DOUBLE = 1058,
	// Token: 0x04006B1E RID: 27422
	NUM_OPTIONS_PLAYED_THIS_TURN = 358,
	// Token: 0x04006B1F RID: 27423
	TO_BE_DESTROYED = 360,
	// Token: 0x04006B20 RID: 27424
	HEALTH_MINIMUM = 337,
	// Token: 0x04006B21 RID: 27425
	AURA = 362,
	// Token: 0x04006B22 RID: 27426
	POISONOUS,
	// Token: 0x04006B23 RID: 27427
	NON_KEYWORD_POISONOUS = 1944,
	// Token: 0x04006B24 RID: 27428
	HERO_POWER_DOUBLE = 366,
	// Token: 0x04006B25 RID: 27429
	AI_MUST_PLAY,
	// Token: 0x04006B26 RID: 27430
	NUM_MINIONS_PLAYER_KILLED_THIS_TURN,
	// Token: 0x04006B27 RID: 27431
	NUM_MINIONS_KILLED_THIS_TURN,
	// Token: 0x04006B28 RID: 27432
	AFFECTED_BY_SPELL_POWER,
	// Token: 0x04006B29 RID: 27433
	SOURCE_OVERRIDE_FOR_MODIFIER_TEXT = 1694,
	// Token: 0x04006B2A RID: 27434
	START_WITH_1_HEALTH = 372,
	// Token: 0x04006B2B RID: 27435
	IMMUNE_WHILE_ATTACKING,
	// Token: 0x04006B2C RID: 27436
	MULTIPLY_HERO_DAMAGE,
	// Token: 0x04006B2D RID: 27437
	MULTIPLY_BUFF_VALUE,
	// Token: 0x04006B2E RID: 27438
	CUSTOM_KEYWORD_EFFECT,
	// Token: 0x04006B2F RID: 27439
	TOPDECK,
	// Token: 0x04006B30 RID: 27440
	HERO_POWER = 380,
	// Token: 0x04006B31 RID: 27441
	HERO_POWER_ENTITY = 1646,
	// Token: 0x04006B32 RID: 27442
	DEATHRATTLE_RETURN_ZONE = 382,
	// Token: 0x04006B33 RID: 27443
	DISPLAYED_CREATOR = 385,
	// Token: 0x04006B34 RID: 27444
	POWERED_UP,
	// Token: 0x04006B35 RID: 27445
	SPARE_PART = 388,
	// Token: 0x04006B36 RID: 27446
	FORGETFUL,
	// Token: 0x04006B37 RID: 27447
	CAN_SUMMON_MAXPLUSONE_MINION,
	// Token: 0x04006B38 RID: 27448
	OBFUSCATED,
	// Token: 0x04006B39 RID: 27449
	BURNING,
	// Token: 0x04006B3A RID: 27450
	OVERLOAD_LOCKED,
	// Token: 0x04006B3B RID: 27451
	NUM_TIMES_HERO_POWER_USED_THIS_GAME,
	// Token: 0x04006B3C RID: 27452
	CURRENT_HEROPOWER_DAMAGE_BONUS,
	// Token: 0x04006B3D RID: 27453
	HEROPOWER_DAMAGE,
	// Token: 0x04006B3E RID: 27454
	LAST_CARD_PLAYED,
	// Token: 0x04006B3F RID: 27455
	NUM_FRIENDLY_MINIONS_THAT_DIED_THIS_TURN,
	// Token: 0x04006B40 RID: 27456
	NUM_CARDS_DRAWN_THIS_TURN,
	// Token: 0x04006B41 RID: 27457
	AI_ONE_SHOT_KILL,
	// Token: 0x04006B42 RID: 27458
	EVIL_GLOW,
	// Token: 0x04006B43 RID: 27459
	HIDE_STATS,
	// Token: 0x04006B44 RID: 27460
	IGNORE_HIDE_STATS_FOR_BIG_CARD = 857,
	// Token: 0x04006B45 RID: 27461
	INSPIRE = 403,
	// Token: 0x04006B46 RID: 27462
	RECEIVES_DOUBLE_SPELLDAMAGE_BONUS,
	// Token: 0x04006B47 RID: 27463
	REVEALED = 410,
	// Token: 0x04006B48 RID: 27464
	NUM_FRIENDLY_MINIONS_THAT_DIED_THIS_GAME = 412,
	// Token: 0x04006B49 RID: 27465
	LOCK_AND_LOAD = 414,
	// Token: 0x04006B4A RID: 27466
	DISCOVER,
	// Token: 0x04006B4B RID: 27467
	USE_DISCOVER_VISUALS = 1342,
	// Token: 0x04006B4C RID: 27468
	SHADOWFORM = 416,
	// Token: 0x04006B4D RID: 27469
	DEATH_KNIGHT = 554,
	// Token: 0x04006B4E RID: 27470
	HISTORY_PROXY = 54,
	// Token: 0x04006B4F RID: 27471
	NUM_FRIENDLY_MINIONS_THAT_ATTACKED_THIS_TURN = 417,
	// Token: 0x04006B50 RID: 27472
	NUM_RESOURCES_SPENT_THIS_GAME,
	// Token: 0x04006B51 RID: 27473
	CHOOSE_BOTH,
	// Token: 0x04006B52 RID: 27474
	ELECTRIC_CHARGE_LEVEL,
	// Token: 0x04006B53 RID: 27475
	HEAVILY_ARMORED,
	// Token: 0x04006B54 RID: 27476
	DONT_SHOW_IMMUNE,
	// Token: 0x04006B55 RID: 27477
	RITUAL = 424,
	// Token: 0x04006B56 RID: 27478
	HISTORY_PROXY_NO_BIG_CARD = 432,
	// Token: 0x04006B57 RID: 27479
	TRANSFORMED_FROM_CARD = 435,
	// Token: 0x04006B58 RID: 27480
	PENDING_TRANSFORM_TO_CARD = 1716,
	// Token: 0x04006B59 RID: 27481
	CTHUN = 436,
	// Token: 0x04006B5A RID: 27482
	CAST_RANDOM_SPELLS,
	// Token: 0x04006B5B RID: 27483
	EMBRACE_THE_SHADOW = 442,
	// Token: 0x04006B5C RID: 27484
	CHOOSE_ONE,
	// Token: 0x04006B5D RID: 27485
	AUTOATTACK = 457,
	// Token: 0x04006B5E RID: 27486
	EXTRA_ATTACKS_THIS_TURN = 444,
	// Token: 0x04006B5F RID: 27487
	SEEN_CTHUN,
	// Token: 0x04006B60 RID: 27488
	MINION_TYPE_REFERENCE = 447,
	// Token: 0x04006B61 RID: 27489
	JADE_GOLEM = 441,
	// Token: 0x04006B62 RID: 27490
	ARMS_DEALING = 458,
	// Token: 0x04006B63 RID: 27491
	MINION_IN_HAND_BUFF = 845,
	// Token: 0x04006B64 RID: 27492
	DEFINING_ENCHANTMENT = 469,
	// Token: 0x04006B65 RID: 27493
	MODIFY_DEFINITION_ATTACK = 473,
	// Token: 0x04006B66 RID: 27494
	MODIFY_DEFINITION_HEALTH,
	// Token: 0x04006B67 RID: 27495
	MODIFY_DEFINITION_COST,
	// Token: 0x04006B68 RID: 27496
	MULTIPLE_CLASSES,
	// Token: 0x04006B69 RID: 27497
	MULTI_CLASS_GROUP = 480,
	// Token: 0x04006B6A RID: 27498
	ALL_TARGETS_RANDOM = 477,
	// Token: 0x04006B6B RID: 27499
	CARD_COSTS_HEALTH = 481,
	// Token: 0x04006B6C RID: 27500
	GRIMY_GOONS,
	// Token: 0x04006B6D RID: 27501
	JADE_LOTUS,
	// Token: 0x04006B6E RID: 27502
	KABAL,
	// Token: 0x04006B6F RID: 27503
	ADDITIONAL_PLAY_REQS_1 = 515,
	// Token: 0x04006B70 RID: 27504
	ADDITIONAL_PLAY_REQS_2,
	// Token: 0x04006B71 RID: 27505
	ELEMENTAL_POWERED_UP = 532,
	// Token: 0x04006B72 RID: 27506
	BOSS = 556,
	// Token: 0x04006B73 RID: 27507
	STAMPEDE = 564,
	// Token: 0x04006B74 RID: 27508
	CORRUPTED = 681,
	// Token: 0x04006B75 RID: 27509
	HIDE_HEALTH,
	// Token: 0x04006B76 RID: 27510
	HIDE_ATTACK,
	// Token: 0x04006B77 RID: 27511
	HIDE_COST,
	// Token: 0x04006B78 RID: 27512
	LIFESTEAL,
	// Token: 0x04006B79 RID: 27513
	GHOSTLY = 785,
	// Token: 0x04006B7A RID: 27514
	DISGUISED_TWIN = 788,
	// Token: 0x04006B7B RID: 27515
	SECRET_DEATHRATTLE,
	// Token: 0x04006B7C RID: 27516
	ZOMBEAST = 823,
	// Token: 0x04006B7D RID: 27517
	HERO_EMOTE_SILENCED = 832,
	// Token: 0x04006B7E RID: 27518
	MODULAR = 849,
	// Token: 0x04006B7F RID: 27519
	GLORIOUSGLOOP = 1044,
	// Token: 0x04006B80 RID: 27520
	REBORN = 1085,
	// Token: 0x04006B81 RID: 27521
	HAS_BEEN_REBORN = 1336,
	// Token: 0x04006B82 RID: 27522
	POISONOUS_INSTANT = 1528,
	// Token: 0x04006B83 RID: 27523
	REPLACEMENT_ENTITY = 1632,
	// Token: 0x04006B84 RID: 27524
	SPELLS_CAST_TWICE = 1681,
	// Token: 0x04006B85 RID: 27525
	LUNAHIGHLIGHTHINT = 1054,
	// Token: 0x04006B86 RID: 27526
	EMPOWER = 1263,
	// Token: 0x04006B87 RID: 27527
	EMPOWER_PRIEST,
	// Token: 0x04006B88 RID: 27528
	EMPOWER_ROGUE,
	// Token: 0x04006B89 RID: 27529
	EMPOWER_SHAMAN,
	// Token: 0x04006B8A RID: 27530
	EMPOWER_WARLOCK,
	// Token: 0x04006B8B RID: 27531
	EMPOWER_WARRIOR,
	// Token: 0x04006B8C RID: 27532
	GOLDSPARKLES_HINT = 1984,
	// Token: 0x04006B8D RID: 27533
	CASTSWHENDRAWN = 1077,
	// Token: 0x04006B8E RID: 27534
	DORMANT_VISUAL = 1090,
	// Token: 0x04006B8F RID: 27535
	DORMANT = 1518,
	// Token: 0x04006B90 RID: 27536
	DORMANT_AWAKEN_CONDITION_ENCHANT,
	// Token: 0x04006B91 RID: 27537
	SHRINE = 1057,
	// Token: 0x04006B92 RID: 27538
	FATIGUEREFERENCE = 1290,
	// Token: 0x04006B93 RID: 27539
	WAND = 1015,
	// Token: 0x04006B94 RID: 27540
	TWINSPELL = 1193,
	// Token: 0x04006B95 RID: 27541
	TWINSPELL_COPY = 1186,
	// Token: 0x04006B96 RID: 27542
	TWINSPELLPENDING = 1269,
	// Token: 0x04006B97 RID: 27543
	EVILZUG = 994,
	// Token: 0x04006B98 RID: 27544
	OVERRIDE_EMOTE_0 = 740,
	// Token: 0x04006B99 RID: 27545
	OVERRIDE_EMOTE_1,
	// Token: 0x04006B9A RID: 27546
	OVERRIDE_EMOTE_2,
	// Token: 0x04006B9B RID: 27547
	OVERRIDE_EMOTE_3,
	// Token: 0x04006B9C RID: 27548
	OVERRIDE_EMOTE_4,
	// Token: 0x04006B9D RID: 27549
	OVERRIDE_EMOTE_5,
	// Token: 0x04006B9E RID: 27550
	HERO_POWER_DISABLED = 777,
	// Token: 0x04006B9F RID: 27551
	RUSH = 791,
	// Token: 0x04006BA0 RID: 27552
	ATTACKABLE_BY_RUSH = 930,
	// Token: 0x04006BA1 RID: 27553
	ECHO = 846,
	// Token: 0x04006BA2 RID: 27554
	NON_KEYWORD_ECHO = 1114,
	// Token: 0x04006BA3 RID: 27555
	OVERKILL = 923,
	// Token: 0x04006BA4 RID: 27556
	PROPHECY,
	// Token: 0x04006BA5 RID: 27557
	ETHEREAL = 880,
	// Token: 0x04006BA6 RID: 27558
	REVEAL_CHOICES = 792,
	// Token: 0x04006BA7 RID: 27559
	HIDDEN_CHOICE = 813,
	// Token: 0x04006BA8 RID: 27560
	REAL_TIME_TRANSFORM = 859,
	// Token: 0x04006BA9 RID: 27561
	HEALTH_DISPLAY = 917,
	// Token: 0x04006BAA RID: 27562
	ENABLE_HEALTH_DISPLAY = 920,
	// Token: 0x04006BAB RID: 27563
	HEALTH_DISPLAY_COLOR = 1046,
	// Token: 0x04006BAC RID: 27564
	HEALTH_DISPLAY_NEGATIVE,
	// Token: 0x04006BAD RID: 27565
	VOODOO_LINK = 921,
	// Token: 0x04006BAE RID: 27566
	COLLECTIONMANAGER_FILTER_MANA_EVEN = 956,
	// Token: 0x04006BAF RID: 27567
	COLLECTIONMANAGER_FILTER_MANA_ODD,
	// Token: 0x04006BB0 RID: 27568
	SUPPRESS_DEATH_SOUND = 959,
	// Token: 0x04006BB1 RID: 27569
	ECHOING_OOZE_SPELL = 963,
	// Token: 0x04006BB2 RID: 27570
	ENCHANTMENT_INVISIBLE = 976,
	// Token: 0x04006BB3 RID: 27571
	WILD = 991,
	// Token: 0x04006BB4 RID: 27572
	HALL_OF_FAME,
	// Token: 0x04006BB5 RID: 27573
	FAST_BATTLECRY = 998,
	// Token: 0x04006BB6 RID: 27574
	CARD_DOES_NOTHING = 1075,
	// Token: 0x04006BB7 RID: 27575
	FORCE_NO_CUSTOM_SPELLS = 1529,
	// Token: 0x04006BB8 RID: 27576
	FORCE_NO_CUSTOM_SUMMON_SPELLS = 1614,
	// Token: 0x04006BB9 RID: 27577
	FORCE_NO_CUSTOM_LIFETIME_SPELLS = 1613,
	// Token: 0x04006BBA RID: 27578
	FORCE_NO_CUSTOM_KEYWORD_SPELLS = 1615,
	// Token: 0x04006BBB RID: 27579
	START_OF_COMBAT = 1531,
	// Token: 0x04006BBC RID: 27580
	PUZZLE = 979,
	// Token: 0x04006BBD RID: 27581
	PUZZLE_PROGRESS,
	// Token: 0x04006BBE RID: 27582
	PUZZLE_PROGRESS_TOTAL,
	// Token: 0x04006BBF RID: 27583
	PUZZLE_TYPE,
	// Token: 0x04006BC0 RID: 27584
	PUZZLE_COMPLETED = 984,
	// Token: 0x04006BC1 RID: 27585
	PUZZLE_NAME = 1026,
	// Token: 0x04006BC2 RID: 27586
	PREVIOUS_PUZZLE_COMPLETED = 1042,
	// Token: 0x04006BC3 RID: 27587
	PUZZLE_MODE = 1073,
	// Token: 0x04006BC4 RID: 27588
	CONCEDE_BUTTON_ALTERNATIVE_TEXT = 985,
	// Token: 0x04006BC5 RID: 27589
	HIDE_RESTART_BUTTON = 990,
	// Token: 0x04006BC6 RID: 27590
	END_TURN_BUTTON_ALTERNATIVE_APPEARANCE = 1000,
	// Token: 0x04006BC7 RID: 27591
	TURN_INDICATOR_ALTERNATIVE_APPEARANCE = 1027,
	// Token: 0x04006BC8 RID: 27592
	DISABLE_TURN_INDICATORS = 1448,
	// Token: 0x04006BC9 RID: 27593
	DECK_RULE_MOD_DECK_SIZE = 997,
	// Token: 0x04006BCA RID: 27594
	DECK_RULE_COUNT_AS_COPY_OF_CARD_ID = 1413,
	// Token: 0x04006BCB RID: 27595
	IGNORE_DECK_RULESET = 1896,
	// Token: 0x04006BCC RID: 27596
	HIDE_OUT_OF_CARDS_WARNING = 1050,
	// Token: 0x04006BCD RID: 27597
	SUPPRESS_JOBS_DONE_VO = 1055,
	// Token: 0x04006BCE RID: 27598
	BLOCK_ALL_INPUT = 1071,
	// Token: 0x04006BCF RID: 27599
	SUPPRESS_ALL_SUMMON_VO = 1458,
	// Token: 0x04006BD0 RID: 27600
	SUPPRESS_SUMMON_VO_FOR_PLAYER = 1521,
	// Token: 0x04006BD1 RID: 27601
	PLAYER_BASE_SHRINE_DECK_ID = 1099,
	// Token: 0x04006BD2 RID: 27602
	DISPLAY_CARD_ON_MOUSEOVER = 1078,
	// Token: 0x04006BD3 RID: 27603
	DECK_POWER_UP = 1080,
	// Token: 0x04006BD4 RID: 27604
	SIDEKICK,
	// Token: 0x04006BD5 RID: 27605
	SIDEKICK_HERO_POWER,
	// Token: 0x04006BD6 RID: 27606
	RUN_PROGRESS = 1113,
	// Token: 0x04006BD7 RID: 27607
	ALTERNATE_MOUSE_OVER_CARD = 1132,
	// Token: 0x04006BD8 RID: 27608
	ENCHANTMENT_BANNER_TEXT = 1135,
	// Token: 0x04006BD9 RID: 27609
	MOUSE_OVER_CARD_APPEARANCE = 1142,
	// Token: 0x04006BDA RID: 27610
	IS_ADVENTURE_SCENARIO = 1172,
	// Token: 0x04006BDB RID: 27611
	COIN_MANA_GEM = 1199,
	// Token: 0x04006BDC RID: 27612
	COIN_MANA_GEM_FOR_CHOICE_CARDS = 1643,
	// Token: 0x04006BDD RID: 27613
	TECH_LEVEL_MANA_GEM = 1442,
	// Token: 0x04006BDE RID: 27614
	BACON_COIN_ON_ENEMY_MINIONS = 1467,
	// Token: 0x04006BDF RID: 27615
	ALWAYS_USE_FAST_ACTOR_TRIGGERS = 1473,
	// Token: 0x04006BE0 RID: 27616
	HEROIC_HERO_POWER = 1282,
	// Token: 0x04006BE1 RID: 27617
	UI_BUFF_ATK_UP = 1297,
	// Token: 0x04006BE2 RID: 27618
	UI_BUFF_COST_DOWN = 1296,
	// Token: 0x04006BE3 RID: 27619
	UI_BUFF_COST_UP = 1298,
	// Token: 0x04006BE4 RID: 27620
	UI_BUFF_HEALTH_UP = 1294,
	// Token: 0x04006BE5 RID: 27621
	UI_BUFF_SET_COST_ZERO,
	// Token: 0x04006BE6 RID: 27622
	UI_BUFF_DURABILITY_UP = 1443,
	// Token: 0x04006BE7 RID: 27623
	GALAKROND_IN_PLAY = 1194,
	// Token: 0x04006BE8 RID: 27624
	OUTCAST = 1333,
	// Token: 0x04006BE9 RID: 27625
	STUDY = 1414,
	// Token: 0x04006BEA RID: 27626
	SPELLBURST = 1427,
	// Token: 0x04006BEB RID: 27627
	CORRUPT = 1524,
	// Token: 0x04006BEC RID: 27628
	CORRUPTEDCARD = 1551,
	// Token: 0x04006BED RID: 27629
	FRENZY = 1637,
	// Token: 0x04006BEE RID: 27630
	RED_MANA_GEM = 449,
	// Token: 0x04006BEF RID: 27631
	BACON_IS_KEL_THUZAD = 1423,
	// Token: 0x04006BF0 RID: 27632
	BACON_TRIPLE_CANDIDATE = 1460,
	// Token: 0x04006BF1 RID: 27633
	BACON_MINION_IS_LEVEL_TWO = 1421,
	// Token: 0x04006BF2 RID: 27634
	BATTLEGROUNDS_PREMIUM_EMOTES = 1463,
	// Token: 0x04006BF3 RID: 27635
	PLAYER_ID_LOOKUP = 1740,
	// Token: 0x04006BF4 RID: 27636
	BLOOD_GEM = 1966,
	// Token: 0x04006BF5 RID: 27637
	FX_DATANUM_1 = 1436,
	// Token: 0x04006BF6 RID: 27638
	BACON_VERDANTSPHERES = 1598,
	// Token: 0x04006BF7 RID: 27639
	METAMORPHOSIS = 1644,
	// Token: 0x04006BF8 RID: 27640
	BACON_AVALANCHE = 1744,
	// Token: 0x04006BF9 RID: 27641
	BACON_COMEONECOMEALL = 1789
}
