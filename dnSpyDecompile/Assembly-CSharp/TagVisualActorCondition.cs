﻿using System;

// Token: 0x02000990 RID: 2448
public enum TagVisualActorCondition
{
	// Token: 0x0400717F RID: 29055
	ALWAYS,
	// Token: 0x04007180 RID: 29056
	AND,
	// Token: 0x04007181 RID: 29057
	OR,
	// Token: 0x04007182 RID: 29058
	DOES_SPELL_HAVE_STATE,
	// Token: 0x04007183 RID: 29059
	DOES_TAG_HAVE_VALUE,
	// Token: 0x04007184 RID: 29060
	IS_ENRAGED,
	// Token: 0x04007185 RID: 29061
	IS_ASLEEP,
	// Token: 0x04007186 RID: 29062
	IS_FRIENDLY,
	// Token: 0x04007187 RID: 29063
	IS_MOUSED_OVER,
	// Token: 0x04007188 RID: 29064
	IS_ENCHANTMENT,
	// Token: 0x04007189 RID: 29065
	IS_DISABLED_HERO_POWER,
	// Token: 0x0400718A RID: 29066
	IS_FROM_SHOW_ENTITY,
	// Token: 0x0400718B RID: 29067
	IS_REAL_TIME_DORMANT = 16,
	// Token: 0x0400718C RID: 29068
	IS_AI_CONTROLLER,
	// Token: 0x0400718D RID: 29069
	IS_FROM_TAG_CHANGE,
	// Token: 0x0400718E RID: 29070
	IS_VALID_OPTION = 20,
	// Token: 0x0400718F RID: 29071
	SHOULD_SHOW_IMMUNE_VISUALS = 12,
	// Token: 0x04007190 RID: 29072
	CAN_SHOW_ACTOR_VISUALS,
	// Token: 0x04007191 RID: 29073
	ATTACHED_CARD_CAN_SHOW_ACTOR_VISUALS,
	// Token: 0x04007192 RID: 29074
	SHOULD_USE_TECH_LEVEL_MANA_GEM,
	// Token: 0x04007193 RID: 29075
	SHOULD_USE_COIN_ON_ENEMY_MINIONS = 19
}