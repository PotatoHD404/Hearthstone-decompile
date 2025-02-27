﻿using System;

// Token: 0x020008F8 RID: 2296
public enum ClientOption
{
	// Token: 0x040067E8 RID: 26600
	INVALID,
	// Token: 0x040067E9 RID: 26601
	SOUND,
	// Token: 0x040067EA RID: 26602
	MUSIC,
	// Token: 0x040067EB RID: 26603
	CURSOR,
	// Token: 0x040067EC RID: 26604
	HUD,
	// Token: 0x040067ED RID: 26605
	STREAMING,
	// Token: 0x040067EE RID: 26606
	SOUND_VOLUME,
	// Token: 0x040067EF RID: 26607
	MUSIC_VOLUME,
	// Token: 0x040067F0 RID: 26608
	GFX_WIDTH,
	// Token: 0x040067F1 RID: 26609
	GFX_HEIGHT,
	// Token: 0x040067F2 RID: 26610
	GFX_FULLSCREEN,
	// Token: 0x040067F3 RID: 26611
	HAS_SEEN_NEW_CINEMATIC,
	// Token: 0x040067F4 RID: 26612
	GFX_QUALITY,
	// Token: 0x040067F5 RID: 26613
	FAKE_PACK_OPENING,
	// Token: 0x040067F6 RID: 26614
	FAKE_PACK_COUNT,
	// Token: 0x040067F7 RID: 26615
	HEALTHY_GAMING_DEBUG,
	// Token: 0x040067F8 RID: 26616
	LAST_SCENE_MODE,
	// Token: 0x040067F9 RID: 26617
	LOCALE,
	// Token: 0x040067FA RID: 26618
	IDLE_KICKER,
	// Token: 0x040067FB RID: 26619
	IDLE_KICK_TIME,
	// Token: 0x040067FC RID: 26620
	BACKGROUND_SOUND,
	// Token: 0x040067FD RID: 26621
	PREFERRED_REGION,
	// Token: 0x040067FE RID: 26622
	NEARBY_PLAYERS,
	// Token: 0x040067FF RID: 26623
	GFX_WIN_CAMERA_CLEAR,
	// Token: 0x04006800 RID: 26624
	GFX_MSAA,
	// Token: 0x04006801 RID: 26625
	GFX_FXAA,
	// Token: 0x04006802 RID: 26626
	GFX_TARGET_FRAME_RATE,
	// Token: 0x04006803 RID: 26627
	GFX_VSYNC,
	// Token: 0x04006804 RID: 26628
	CARD_BACK,
	// Token: 0x04006805 RID: 26629
	CARD_BACK2,
	// Token: 0x04006806 RID: 26630
	LOCAL_TUTORIAL_PROGRESS,
	// Token: 0x04006807 RID: 26631
	CONNECT_TO_AURORA,
	// Token: 0x04006808 RID: 26632
	RECONNECT,
	// Token: 0x04006809 RID: 26633
	RECONNECT_TIMEOUT,
	// Token: 0x0400680A RID: 26634
	RECONNECT_RETRY_TIME,
	// Token: 0x0400680B RID: 26635
	CHANGED_CARDS_DATA,
	// Token: 0x0400680C RID: 26636
	KELTHUZADTAUNTS,
	// Token: 0x0400680D RID: 26637
	GFX_WIN_POSX,
	// Token: 0x0400680E RID: 26638
	GFX_WIN_POSY,
	// Token: 0x0400680F RID: 26639
	PREFERRED_CDN_INDEX,
	// Token: 0x04006810 RID: 26640
	LAST_FAILED_DOP_VERSION,
	// Token: 0x04006811 RID: 26641
	TOUCH_MODE,
	// Token: 0x04006812 RID: 26642
	SHOWN_GFX_DEVICE_WARNING,
	// Token: 0x04006813 RID: 26643
	INTRO,
	// Token: 0x04006814 RID: 26644
	DISABLE_LOGIN_POPUPS,
	// Token: 0x04006815 RID: 26645
	TUTORIAL_LOST_PROGRESS,
	// Token: 0x04006816 RID: 26646
	ERROR_SCREEN,
	// Token: 0x04006817 RID: 26647
	CLIENT_OPTIONS_VERSION,
	// Token: 0x04006818 RID: 26648
	IKS_VIEW_ATTEMPTS,
	// Token: 0x04006819 RID: 26649
	IKS_LAST_DOWNLOAD_TIME,
	// Token: 0x0400681A RID: 26650
	IKS_LAST_DOWNLOAD_RESPONSE,
	// Token: 0x0400681B RID: 26651
	IKS_LAST_STORED_RESPONSE,
	// Token: 0x0400681C RID: 26652
	IKS_CACHE_AGE,
	// Token: 0x0400681D RID: 26653
	SEEN_PACK_PRODUCT_LIST,
	// Token: 0x0400681E RID: 26654
	CHEAT_HISTORY,
	// Token: 0x0400681F RID: 26655
	PRELOAD_CARD_ASSETS,
	// Token: 0x04006820 RID: 26656
	COLLECTION_PREMIUM_TYPE,
	// Token: 0x04006821 RID: 26657
	DEV_TIMESCALE,
	// Token: 0x04006822 RID: 26658
	IKS_LAST_SHOWN_AD,
	// Token: 0x04006823 RID: 26659
	SHOW_STANDARD_ONLY,
	// Token: 0x04006824 RID: 26660
	DISABLE_SET_ROTATION_INTRO,
	// Token: 0x04006825 RID: 26661
	FORCE_SHOW_IKS,
	// Token: 0x04006826 RID: 26662
	PEGUI_DEBUG,
	// Token: 0x04006827 RID: 26663
	SKIP_ALL_MULLIGANS,
	// Token: 0x04006828 RID: 26664
	IS_TEMPORARY_ACCOUNT_CHEAT,
	// Token: 0x04006829 RID: 26665
	TEMPORARY_ACCOUNT_DATA,
	// Token: 0x0400682A RID: 26666
	DISALLOWED_CLOUD_STORAGE,
	// Token: 0x0400682B RID: 26667
	CREATED_ACCOUNT,
	// Token: 0x0400682C RID: 26668
	LAST_HEAL_UP_EVENT_DATE,
	// Token: 0x0400682D RID: 26669
	PUSH_NOTIFICATION_STATUS,
	// Token: 0x0400682E RID: 26670
	DBF_XML_LOADING,
	// Token: 0x0400682F RID: 26671
	HAS_SHOWN_DEVICE_PERFORMANCE_WARNING,
	// Token: 0x04006830 RID: 26672
	SCREENSHOT_DIRECTORY,
	// Token: 0x04006831 RID: 26673
	ASSET_DOWNLOAD_ENABLED,
	// Token: 0x04006832 RID: 26674
	UPDATE_STATE,
	// Token: 0x04006833 RID: 26675
	NATIVE_UPDATE_STATE,
	// Token: 0x04006834 RID: 26676
	ASK_UNKNOWN_APPS,
	// Token: 0x04006835 RID: 26677
	SIMULATE_CELLULAR,
	// Token: 0x04006836 RID: 26678
	LAUNCH_COUNT,
	// Token: 0x04006837 RID: 26679
	FIRST_INSTALL_TIME,
	// Token: 0x04006838 RID: 26680
	UPDATED_CLIENT_VERSION,
	// Token: 0x04006839 RID: 26681
	UPDATE_STOP_LEVEL,
	// Token: 0x0400683A RID: 26682
	SIMULATE_NO_INTERNET,
	// Token: 0x0400683B RID: 26683
	MAX_DOWNLOAD_SPEED,
	// Token: 0x0400683C RID: 26684
	STREAMING_SPEED_IN_GAME,
	// Token: 0x0400683D RID: 26685
	AUTOCONVERT_VIRTUAL_CURRENCY,
	// Token: 0x0400683E RID: 26686
	STREAMER_MODE,
	// Token: 0x0400683F RID: 26687
	LATEST_SEEN_SHOP_PRODUCT_LIST,
	// Token: 0x04006840 RID: 26688
	LATEST_DISPLAYED_SHOP_PRODUCT_LIST,
	// Token: 0x04006841 RID: 26689
	IS_INSTALL_REPORTED,
	// Token: 0x04006842 RID: 26690
	RANK_DEBUG,
	// Token: 0x04006843 RID: 26691
	DEBUG_CURSOR,
	// Token: 0x04006844 RID: 26692
	CRASH_COUNT,
	// Token: 0x04006845 RID: 26693
	EXCEPTION_COUNT,
	// Token: 0x04006846 RID: 26694
	LOW_MEMORY_COUNT,
	// Token: 0x04006847 RID: 26695
	CLOSED_WITHOUT_CRASH,
	// Token: 0x04006848 RID: 26696
	EXCEPTION_HASH,
	// Token: 0x04006849 RID: 26697
	LAST_EXCEPTION_HASH,
	// Token: 0x0400684A RID: 26698
	CRASH_IN_A_ROW_COUNT,
	// Token: 0x0400684B RID: 26699
	SAME_EXCEPTION_COUNT,
	// Token: 0x0400684C RID: 26700
	CELL_PROMPT_THRESHOLD,
	// Token: 0x0400684D RID: 26701
	DOWNLOAD_ALL_FINISHED,
	// Token: 0x0400684E RID: 26702
	DELAYED_REPORTER_STOP,
	// Token: 0x0400684F RID: 26703
	SCREEN_SHAKE_ENABLED,
	// Token: 0x04006850 RID: 26704
	HUD_CONFIG,
	// Token: 0x04006851 RID: 26705
	HUD_SCALE,
	// Token: 0x04006852 RID: 26706
	ENABLED_LOG_LIST,
	// Token: 0x04006853 RID: 26707
	HAS_SEEN_CLIPBOARD_NOTIFICATION,
	// Token: 0x04006854 RID: 26708
	PROG_TILE_DEBUG,
	// Token: 0x04006855 RID: 26709
	LAST_LOGIN_TYPE,
	// Token: 0x04006856 RID: 26710
	TRANSITION_AUTH_TOKEN,
	// Token: 0x04006857 RID: 26711
	TRANSITION_GUEST_ID,
	// Token: 0x04006858 RID: 26712
	ANR_THROTTLE,
	// Token: 0x04006859 RID: 26713
	ANR_WAIT_SECONDS,
	// Token: 0x0400685A RID: 26714
	HAS_ACCEPTED_PRIVACY_POLICY_AND_EULA,
	// Token: 0x0400685B RID: 26715
	APP_RATING_POPUP_COUNT,
	// Token: 0x0400685C RID: 26716
	NEWEST_REWARDED_DECK_ID,
	// Token: 0x0400685D RID: 26717
	SHOW_CREATE_SKIP_ACCT
}
