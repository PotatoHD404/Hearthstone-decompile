﻿using System;

// Token: 0x0200097B RID: 2427
public enum SpellType
{
	// Token: 0x04006FFB RID: 28667
	NONE,
	// Token: 0x04006FFC RID: 28668
	SUMMON_OUT,
	// Token: 0x04006FFD RID: 28669
	SUMMON_IN,
	// Token: 0x04006FFE RID: 28670
	PLAY,
	// Token: 0x04006FFF RID: 28671
	TRIGGER,
	// Token: 0x04007000 RID: 28672
	DEATH,
	// Token: 0x04007001 RID: 28673
	ATTACK,
	// Token: 0x04007002 RID: 28674
	DAMAGE,
	// Token: 0x04007003 RID: 28675
	TAUNT,
	// Token: 0x04007004 RID: 28676
	DIVINE_SHIELD,
	// Token: 0x04007005 RID: 28677
	SKULL,
	// Token: 0x04007006 RID: 28678
	STEALTH,
	// Token: 0x04007007 RID: 28679
	ENRAGE,
	// Token: 0x04007008 RID: 28680
	IMMUNE,
	// Token: 0x04007009 RID: 28681
	FROZEN,
	// Token: 0x0400700A RID: 28682
	SPELL_POWER,
	// Token: 0x0400700B RID: 28683
	POWER_UP,
	// Token: 0x0400700C RID: 28684
	FRIENDLY_ATTACK,
	// Token: 0x0400700D RID: 28685
	OPPONENT_ATTACK,
	// Token: 0x0400700E RID: 28686
	DEPRECATED_FRIENDLY_IMPACT,
	// Token: 0x0400700F RID: 28687
	DEPRECATED_OPPONENT_IMPACT,
	// Token: 0x04007010 RID: 28688
	WIGGLE,
	// Token: 0x04007011 RID: 28689
	SUMMON_OUT_MEDIUM,
	// Token: 0x04007012 RID: 28690
	SUMMON_OUT_LARGE,
	// Token: 0x04007013 RID: 28691
	SUMMON_IN_MEDIUM,
	// Token: 0x04007014 RID: 28692
	SUMMON_IN_LARGE,
	// Token: 0x04007015 RID: 28693
	FRIENDLY_SPAWN_MINION,
	// Token: 0x04007016 RID: 28694
	ENCHANT_POSITIVE,
	// Token: 0x04007017 RID: 28695
	ENCHANT_NEGATIVE,
	// Token: 0x04007018 RID: 28696
	ENCHANT_NEUTRAL,
	// Token: 0x04007019 RID: 28697
	SUMMON_JARAXXUS,
	// Token: 0x0400701A RID: 28698
	OPPONENT_SPAWN_MINION,
	// Token: 0x0400701B RID: 28699
	WINDFURY_IDLE,
	// Token: 0x0400701C RID: 28700
	BATTLECRY,
	// Token: 0x0400701D RID: 28701
	DEATHRATTLE_IDLE,
	// Token: 0x0400701E RID: 28702
	DEATHRATTLE_DEATH,
	// Token: 0x0400701F RID: 28703
	SILENCE,
	// Token: 0x04007020 RID: 28704
	ENDGAME_WIN,
	// Token: 0x04007021 RID: 28705
	ENDGAME_LOSE,
	// Token: 0x04007022 RID: 28706
	ENDGAME_DRAW,
	// Token: 0x04007023 RID: 28707
	FATIGUE_DEATH,
	// Token: 0x04007024 RID: 28708
	SUMMON_IN_FRIENDLY,
	// Token: 0x04007025 RID: 28709
	SUMMON_IN_OPPONENT,
	// Token: 0x04007026 RID: 28710
	SUMMON_OUT_WEAPON,
	// Token: 0x04007027 RID: 28711
	SHEATHE,
	// Token: 0x04007028 RID: 28712
	UNSHEATHE,
	// Token: 0x04007029 RID: 28713
	SPELL_POWER_HINT_IDLE,
	// Token: 0x0400702A RID: 28714
	UNTARGETABLE,
	// Token: 0x0400702B RID: 28715
	SPELL_POWER_HINT_BURST,
	// Token: 0x0400702C RID: 28716
	WINDFURY_BURST,
	// Token: 0x0400702D RID: 28717
	EMOTE,
	// Token: 0x0400702E RID: 28718
	DEATHREVERSE,
	// Token: 0x0400702F RID: 28719
	Zzz,
	// Token: 0x04007030 RID: 28720
	SUMMON_IN_PREMIUM,
	// Token: 0x04007031 RID: 28721
	SUMMON_IN_MEDIUM_PREMIUM,
	// Token: 0x04007032 RID: 28722
	SUMMON_IN_LARGE_PREMIUM,
	// Token: 0x04007033 RID: 28723
	SUMMON_OUT_PREMIUM,
	// Token: 0x04007034 RID: 28724
	CONSTRUCT,
	// Token: 0x04007035 RID: 28725
	FLIP_OVER,
	// Token: 0x04007036 RID: 28726
	GHOSTMODE,
	// Token: 0x04007037 RID: 28727
	BURN,
	// Token: 0x04007038 RID: 28728
	BURST_COMMON,
	// Token: 0x04007039 RID: 28729
	BURST_RARE,
	// Token: 0x0400703A RID: 28730
	BURST_EPIC,
	// Token: 0x0400703B RID: 28731
	BURST_LEGENDARY,
	// Token: 0x0400703C RID: 28732
	SUMMON_IN_FORGE,
	// Token: 0x0400703D RID: 28733
	SUMMON_OUT_FORGE,
	// Token: 0x0400703E RID: 28734
	DECONSTRUCT,
	// Token: 0x0400703F RID: 28735
	SUMMON_IN_OPPONENT_MEDIUM,
	// Token: 0x04007040 RID: 28736
	SUMMON_IN_OPPONENT_LARGE,
	// Token: 0x04007041 RID: 28737
	SUMMON_IN_OPPONENT_PREMIUM,
	// Token: 0x04007042 RID: 28738
	SUMMON_IN_OPPONENT_MEDIUM_PREMIUM,
	// Token: 0x04007043 RID: 28739
	SUMMON_IN_OPPONENT_LARGE_PREMIUM,
	// Token: 0x04007044 RID: 28740
	SHOUT_BUFF,
	// Token: 0x04007045 RID: 28741
	TAUNT_PREMIUM,
	// Token: 0x04007046 RID: 28742
	AURA,
	// Token: 0x04007047 RID: 28743
	POISONOUS,
	// Token: 0x04007048 RID: 28744
	HANDFULL,
	// Token: 0x04007049 RID: 28745
	CHOFLOAT,
	// Token: 0x0400704A RID: 28746
	CHODEATH,
	// Token: 0x0400704B RID: 28747
	TAUNT_STEALTH,
	// Token: 0x0400704C RID: 28748
	TAUNT_PREMIUM_STEALTH,
	// Token: 0x0400704D RID: 28749
	GHOSTCARD,
	// Token: 0x0400704E RID: 28750
	MISSING_BIGCARD,
	// Token: 0x0400704F RID: 28751
	CHARGE,
	// Token: 0x04007050 RID: 28752
	OOZE,
	// Token: 0x04007051 RID: 28753
	AUTO_CAST,
	// Token: 0x04007052 RID: 28754
	NOBATTLECRY,
	// Token: 0x04007053 RID: 28755
	STEADY_SHOT_CAN_TARGET,
	// Token: 0x04007054 RID: 28756
	FAST_TRIGGER,
	// Token: 0x04007055 RID: 28757
	BURNING,
	// Token: 0x04007056 RID: 28758
	EXPLODE,
	// Token: 0x04007057 RID: 28759
	EVIL_GLOW,
	// Token: 0x04007058 RID: 28760
	CURRENT_HEROPOWER_DAMAGE_BONUS,
	// Token: 0x04007059 RID: 28761
	INSPIRE,
	// Token: 0x0400705A RID: 28762
	LOCK_AND_LOAD,
	// Token: 0x0400705B RID: 28763
	BOUNCE_OUT,
	// Token: 0x0400705C RID: 28764
	BOUNCE_IN,
	// Token: 0x0400705D RID: 28765
	SHADOWFORM,
	// Token: 0x0400705E RID: 28766
	HEAVILY_ARMORED,
	// Token: 0x0400705F RID: 28767
	ELECTRIC_CHARGE_LEVEL_SMALL,
	// Token: 0x04007060 RID: 28768
	ELECTRIC_CHARGE_LEVEL_MEDIUM,
	// Token: 0x04007061 RID: 28769
	ELECTRIC_CHARGE_LEVEL_LARGE,
	// Token: 0x04007062 RID: 28770
	SUMMON_IN_CUSTOM,
	// Token: 0x04007063 RID: 28771
	DEPRECATED_CAST_RANDOM_SPELLS,
	// Token: 0x04007064 RID: 28772
	SHIFTING,
	// Token: 0x04007065 RID: 28773
	SPELLS_COST_HEALTH,
	// Token: 0x04007066 RID: 28774
	CHOOSE_BOTH,
	// Token: 0x04007067 RID: 28775
	EMBRACE_THE_SHADOW,
	// Token: 0x04007068 RID: 28776
	DOOMEDMINION,
	// Token: 0x04007069 RID: 28777
	ARMS_DEALING,
	// Token: 0x0400706A RID: 28778
	DEPRECATED_111,
	// Token: 0x0400706B RID: 28779
	ELEMENTAL_POWERED_UP,
	// Token: 0x0400706C RID: 28780
	STAMPEDE,
	// Token: 0x0400706D RID: 28781
	CORRUPTED,
	// Token: 0x0400706E RID: 28782
	DEATH_KNIGHT,
	// Token: 0x0400706F RID: 28783
	LIFESTEAL,
	// Token: 0x04007070 RID: 28784
	SUMMON_OUT_HERO,
	// Token: 0x04007071 RID: 28785
	IS_VAMPIRE,
	// Token: 0x04007072 RID: 28786
	VALEERASHADOW,
	// Token: 0x04007073 RID: 28787
	ZOMBEAST,
	// Token: 0x04007074 RID: 28788
	ONE_SIDED_GHOSTLY,
	// Token: 0x04007075 RID: 28789
	HERO_EMOTE_SILENCED,
	// Token: 0x04007076 RID: 28790
	VOODOO_LINK,
	// Token: 0x04007077 RID: 28791
	RUSH,
	// Token: 0x04007078 RID: 28792
	FLAME_SYMBOL,
	// Token: 0x04007079 RID: 28793
	GHOSTLY_SUMMON_IN,
	// Token: 0x0400707A RID: 28794
	GHOSTLY_DEATH,
	// Token: 0x0400707B RID: 28795
	GHOSTLY,
	// Token: 0x0400707C RID: 28796
	MAGNETIC_HAND_UNLINKED,
	// Token: 0x0400707D RID: 28797
	MAGNETIC_HAND_LINKED_RIGHT,
	// Token: 0x0400707E RID: 28798
	MAGNETIC_PLAY_UNLINKED_LEFT,
	// Token: 0x0400707F RID: 28799
	MAGNETIC_PLAY_LINKED_LEFT,
	// Token: 0x04007080 RID: 28800
	MAGNETIC_PLAY_LINKED_RIGHT,
	// Token: 0x04007081 RID: 28801
	FRIENDLY_SPAWN_HERO,
	// Token: 0x04007082 RID: 28802
	OPPONENT_SPAWN_HERO,
	// Token: 0x04007083 RID: 28803
	GLORIOUSGLOOP,
	// Token: 0x04007084 RID: 28804
	LUNAHIGHLIGHTHINT,
	// Token: 0x04007085 RID: 28805
	MAGNETIC_PLAY_UNLINKED_LEFT_DIMMED,
	// Token: 0x04007086 RID: 28806
	RESERVED_139,
	// Token: 0x04007087 RID: 28807
	DECK_POWER_UP,
	// Token: 0x04007088 RID: 28808
	DORMANT,
	// Token: 0x04007089 RID: 28809
	OVERKILL,
	// Token: 0x0400708A RID: 28810
	HEALING_DOES_DAMAGE_HINT_IDLE,
	// Token: 0x0400708B RID: 28811
	HEALING_DOES_DAMAGE_HINT_BURST,
	// Token: 0x0400708C RID: 28812
	COIN_MANA_GEM,
	// Token: 0x0400708D RID: 28813
	TWINSPELLPENDING,
	// Token: 0x0400708E RID: 28814
	TWINSPELL_SUMMON_IN,
	// Token: 0x0400708F RID: 28815
	REBORN,
	// Token: 0x04007090 RID: 28816
	REBORN_SPAWN,
	// Token: 0x04007091 RID: 28817
	REBORN_DEATH,
	// Token: 0x04007092 RID: 28818
	SUMMON_IN_DUNGEON_CRAWL,
	// Token: 0x04007093 RID: 28819
	BOUNCE_IN_FAST,
	// Token: 0x04007094 RID: 28820
	BOUNCE_OUT_FAST,
	// Token: 0x04007095 RID: 28821
	TWINSPELL_SUMMON_IN_FAST,
	// Token: 0x04007096 RID: 28822
	AUTO_ATTACK_WITH_HIGHLIGHT,
	// Token: 0x04007097 RID: 28823
	TECH_LEVEL_MANA_GEM,
	// Token: 0x04007098 RID: 28824
	BACON_SHOP_MINION_COIN,
	// Token: 0x04007099 RID: 28825
	BACON_TRIPLE_CANDIDATE,
	// Token: 0x0400709A RID: 28826
	RED_MANA_GEM,
	// Token: 0x0400709B RID: 28827
	SPELLBURST,
	// Token: 0x0400709C RID: 28828
	SUMMON_OUT_TECH_LEVEL,
	// Token: 0x0400709D RID: 28829
	BOUNCE_IN_TECH_LEVEL,
	// Token: 0x0400709E RID: 28830
	SHIFTING_TECH_LEVEL,
	// Token: 0x0400709F RID: 28831
	SUMMON_OUT_TECH_LEVEL_PREMIUM,
	// Token: 0x040070A0 RID: 28832
	AWAKEN_FROM_DORMANT,
	// Token: 0x040070A1 RID: 28833
	POISONOUS_INSTANT,
	// Token: 0x040070A2 RID: 28834
	SUMMON_IN_FAST,
	// Token: 0x040070A3 RID: 28835
	SUMMON_IN_PREMIUM_FAST,
	// Token: 0x040070A4 RID: 28836
	SUMMON_IN_OPPONENT_FAST,
	// Token: 0x040070A5 RID: 28837
	MAGTHERIDON_LINK,
	// Token: 0x040070A6 RID: 28838
	SUMMON_IN_HERO,
	// Token: 0x040070A7 RID: 28839
	TAUNT_INSTANT,
	// Token: 0x040070A8 RID: 28840
	TAUNT_INSTANT_PREMIUM,
	// Token: 0x040070A9 RID: 28841
	METAMORPHOSIS,
	// Token: 0x040070AA RID: 28842
	SHUFFLE_DECK,
	// Token: 0x040070AB RID: 28843
	SPELLS_CAST_TWICE,
	// Token: 0x040070AC RID: 28844
	RESERVED_1960,
	// Token: 0x040070AD RID: 28845
	BACON_ODD_PLAYER,
	// Token: 0x040070AE RID: 28846
	LIFESTEAL_DOES_DAMAGE_HINT_IDLE,
	// Token: 0x040070AF RID: 28847
	RESERVED_1960_180,
	// Token: 0x040070B0 RID: 28848
	RESERVED_1960_181,
	// Token: 0x040070B1 RID: 28849
	RESERVED_1960_182,
	// Token: 0x040070B2 RID: 28850
	RESERVED_1960_183,
	// Token: 0x040070B3 RID: 28851
	RESERVED_1960_184,
	// Token: 0x040070B4 RID: 28852
	DARKMOON_TICKET,
	// Token: 0x040070B5 RID: 28853
	SUMMON_IN_DIAMOND,
	// Token: 0x040070B6 RID: 28854
	SUMMON_IN_MEDIUM_DIAMOND,
	// Token: 0x040070B7 RID: 28855
	SUMMON_IN_LARGE_DIAMOND,
	// Token: 0x040070B8 RID: 28856
	SUMMON_IN_DIAMOND_FAST,
	// Token: 0x040070B9 RID: 28857
	SUMMON_IN_OPPONENT_DIAMOND,
	// Token: 0x040070BA RID: 28858
	SUMMON_IN_OPPONENT_MEDIUM_DIAMOND,
	// Token: 0x040070BB RID: 28859
	SUMMON_IN_OPPONENT_LARGE_DIAMOND,
	// Token: 0x040070BC RID: 28860
	SUMMON_OUT_DIAMOND,
	// Token: 0x040070BD RID: 28861
	TAUNT_DIAMOND,
	// Token: 0x040070BE RID: 28862
	TAUNT_DIAMOND_STEALTH,
	// Token: 0x040070BF RID: 28863
	TAUNT_INSTANT_DIAMOND,
	// Token: 0x040070C0 RID: 28864
	FRENZY,
	// Token: 0x040070C1 RID: 28865
	PLACEHOLDER_22,
	// Token: 0x040070C2 RID: 28866
	PLACEHOLDER_20_6,
	// Token: 0x040070C3 RID: 28867
	GHOSTLY_DIAMOND,
	// Token: 0x040070C4 RID: 28868
	GOLDSPARKLES_HINT,
	// Token: 0x040070C5 RID: 28869
	PLACEHOLDER_20_6_2
}
