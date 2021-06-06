using System;

public class OptionDataTables
{
	public static readonly Map<Option, Type> s_typeMap = new Map<Option, Type>
	{
		{
			Option.SOUND,
			typeof(bool)
		},
		{
			Option.MUSIC,
			typeof(bool)
		},
		{
			Option.CURSOR,
			typeof(bool)
		},
		{
			Option.HUD,
			typeof(bool)
		},
		{
			Option.STREAMING,
			typeof(bool)
		},
		{
			Option.SOUND_VOLUME,
			typeof(float)
		},
		{
			Option.MUSIC_VOLUME,
			typeof(float)
		},
		{
			Option.GFX_WIDTH,
			typeof(int)
		},
		{
			Option.GFX_HEIGHT,
			typeof(int)
		},
		{
			Option.GFX_FULLSCREEN,
			typeof(bool)
		},
		{
			Option.HAS_SEEN_NEW_CINEMATIC,
			typeof(bool)
		},
		{
			Option.GFX_QUALITY,
			typeof(int)
		},
		{
			Option.FAKE_PACK_OPENING,
			typeof(bool)
		},
		{
			Option.FAKE_PACK_COUNT,
			typeof(int)
		},
		{
			Option.HEALTHY_GAMING_DEBUG,
			typeof(bool)
		},
		{
			Option.LAST_SCENE_MODE,
			typeof(int)
		},
		{
			Option.LOCALE,
			typeof(string)
		},
		{
			Option.IDLE_KICKER,
			typeof(bool)
		},
		{
			Option.IDLE_KICK_TIME,
			typeof(string)
		},
		{
			Option.BACKGROUND_SOUND,
			typeof(bool)
		},
		{
			Option.PREFERRED_REGION,
			typeof(int)
		},
		{
			Option.NEARBY_PLAYERS,
			typeof(bool)
		},
		{
			Option.GFX_WIN_CAMERA_CLEAR,
			typeof(bool)
		},
		{
			Option.GFX_MSAA,
			typeof(int)
		},
		{
			Option.GFX_FXAA,
			typeof(bool)
		},
		{
			Option.GFX_TARGET_FRAME_RATE,
			typeof(int)
		},
		{
			Option.GFX_VSYNC,
			typeof(int)
		},
		{
			Option.CARD_BACK,
			typeof(int)
		},
		{
			Option.CARD_BACK2,
			typeof(int)
		},
		{
			Option.LOCAL_TUTORIAL_PROGRESS,
			typeof(int)
		},
		{
			Option.CONNECT_TO_AURORA,
			typeof(bool)
		},
		{
			Option.RECONNECT,
			typeof(bool)
		},
		{
			Option.RECONNECT_TIMEOUT,
			typeof(float)
		},
		{
			Option.RECONNECT_RETRY_TIME,
			typeof(float)
		},
		{
			Option.CHANGED_CARDS_DATA,
			typeof(string)
		},
		{
			Option.KELTHUZADTAUNTS,
			typeof(int)
		},
		{
			Option.GFX_WIN_POSX,
			typeof(int)
		},
		{
			Option.GFX_WIN_POSY,
			typeof(int)
		},
		{
			Option.PREFERRED_CDN_INDEX,
			typeof(int)
		},
		{
			Option.LAST_FAILED_DOP_VERSION,
			typeof(int)
		},
		{
			Option.TOUCH_MODE,
			typeof(bool)
		},
		{
			Option.SHOWN_GFX_DEVICE_WARNING,
			typeof(bool)
		},
		{
			Option.INTRO,
			typeof(bool)
		},
		{
			Option.DISABLE_LOGIN_POPUPS,
			typeof(bool)
		},
		{
			Option.TUTORIAL_LOST_PROGRESS,
			typeof(int)
		},
		{
			Option.ERROR_SCREEN,
			typeof(bool)
		},
		{
			Option.CLIENT_OPTIONS_VERSION,
			typeof(int)
		},
		{
			Option.IKS_VIEW_ATTEMPTS,
			typeof(int)
		},
		{
			Option.IKS_LAST_DOWNLOAD_TIME,
			typeof(ulong)
		},
		{
			Option.IKS_LAST_DOWNLOAD_RESPONSE,
			typeof(string)
		},
		{
			Option.IKS_LAST_STORED_RESPONSE,
			typeof(string)
		},
		{
			Option.IKS_CACHE_AGE,
			typeof(int)
		},
		{
			Option.SEEN_PACK_PRODUCT_LIST,
			typeof(string)
		},
		{
			Option.CHEAT_HISTORY,
			typeof(string)
		},
		{
			Option.PRELOAD_CARD_ASSETS,
			typeof(bool)
		},
		{
			Option.COLLECTION_PREMIUM_TYPE,
			typeof(string)
		},
		{
			Option.DEV_TIMESCALE,
			typeof(float)
		},
		{
			Option.IKS_LAST_SHOWN_AD,
			typeof(string)
		},
		{
			Option.SHOW_STANDARD_ONLY,
			typeof(bool)
		},
		{
			Option.DISABLE_SET_ROTATION_INTRO,
			typeof(bool)
		},
		{
			Option.FORCE_SHOW_IKS,
			typeof(bool)
		},
		{
			Option.PEGUI_DEBUG,
			typeof(int)
		},
		{
			Option.SKIP_ALL_MULLIGANS,
			typeof(bool)
		},
		{
			Option.IS_TEMPORARY_ACCOUNT_CHEAT,
			typeof(bool)
		},
		{
			Option.TEMPORARY_ACCOUNT_DATA,
			typeof(string)
		},
		{
			Option.DISALLOWED_CLOUD_STORAGE,
			typeof(bool)
		},
		{
			Option.CREATED_ACCOUNT,
			typeof(bool)
		},
		{
			Option.LAST_HEAL_UP_EVENT_DATE,
			typeof(long)
		},
		{
			Option.LATEST_SEEN_TAVERNBRAWL_SESSION_LIMIT,
			typeof(int)
		},
		{
			Option.PUSH_NOTIFICATION_STATUS,
			typeof(int)
		},
		{
			Option.DBF_XML_LOADING,
			typeof(bool)
		},
		{
			Option.HAS_SHOWN_DEVICE_PERFORMANCE_WARNING,
			typeof(bool)
		},
		{
			Option.SCREENSHOT_DIRECTORY,
			typeof(string)
		},
		{
			Option.SIMULATE_CELLULAR,
			typeof(bool)
		},
		{
			Option.ASSET_DOWNLOAD_ENABLED,
			typeof(bool)
		},
		{
			Option.UPDATE_STATE,
			typeof(int)
		},
		{
			Option.NATIVE_UPDATE_STATE,
			typeof(string)
		},
		{
			Option.ASK_UNKNOWN_APPS,
			typeof(bool)
		},
		{
			Option.LAUNCH_COUNT,
			typeof(int)
		},
		{
			Option.IS_INSTALL_REPORTED,
			typeof(bool)
		},
		{
			Option.FIRST_INSTALL_TIME,
			typeof(ulong)
		},
		{
			Option.UPDATED_CLIENT_VERSION,
			typeof(string)
		},
		{
			Option.UPDATE_STOP_LEVEL,
			typeof(int)
		},
		{
			Option.SIMULATE_NO_INTERNET,
			typeof(bool)
		},
		{
			Option.MAX_DOWNLOAD_SPEED,
			typeof(int)
		},
		{
			Option.STREAMING_SPEED_IN_GAME,
			typeof(int)
		},
		{
			Option.AUTOCONVERT_VIRTUAL_CURRENCY,
			typeof(bool)
		},
		{
			Option.STREAMER_MODE,
			typeof(bool)
		},
		{
			Option.LATEST_SEEN_SHOP_PRODUCT_LIST,
			typeof(string)
		},
		{
			Option.LATEST_DISPLAYED_SHOP_PRODUCT_LIST,
			typeof(string)
		},
		{
			Option.RANK_DEBUG,
			typeof(int)
		},
		{
			Option.DEBUG_CURSOR,
			typeof(bool)
		},
		{
			Option.CRASH_COUNT,
			typeof(int)
		},
		{
			Option.EXCEPTION_COUNT,
			typeof(int)
		},
		{
			Option.LOW_MEMORY_COUNT,
			typeof(int)
		},
		{
			Option.CLOSED_WITHOUT_CRASH,
			typeof(bool)
		},
		{
			Option.EXCEPTION_HASH,
			typeof(string)
		},
		{
			Option.LAST_EXCEPTION_HASH,
			typeof(string)
		},
		{
			Option.CRASH_IN_A_ROW_COUNT,
			typeof(int)
		},
		{
			Option.SAME_EXCEPTION_COUNT,
			typeof(int)
		},
		{
			Option.CELL_PROMPT_THRESHOLD,
			typeof(int)
		},
		{
			Option.DOWNLOAD_ALL_FINISHED,
			typeof(bool)
		},
		{
			Option.DELAYED_REPORTER_STOP,
			typeof(bool)
		},
		{
			Option.SCREEN_SHAKE_ENABLED,
			typeof(bool)
		},
		{
			Option.HUD_CONFIG,
			typeof(string)
		},
		{
			Option.HUD_SCALE,
			typeof(float)
		},
		{
			Option.ENABLED_LOG_LIST,
			typeof(string)
		},
		{
			Option.HAS_SEEN_CLIPBOARD_NOTIFICATION,
			typeof(bool)
		},
		{
			Option.PROG_TILE_DEBUG,
			typeof(bool)
		},
		{
			Option.LAST_LOGIN_TYPE,
			typeof(int)
		},
		{
			Option.TRANSITION_AUTH_TOKEN,
			typeof(string)
		},
		{
			Option.TRANSITION_GUEST_ID,
			typeof(string)
		},
		{
			Option.ANR_THROTTLE,
			typeof(float)
		},
		{
			Option.ANR_WAIT_SECONDS,
			typeof(float)
		},
		{
			Option.HAS_ACCEPTED_PRIVACY_POLICY_AND_EULA,
			typeof(bool)
		},
		{
			Option.APP_RATING_POPUP_COUNT,
			typeof(int)
		},
		{
			Option.NEWEST_REWARDED_DECK_ID,
			typeof(long)
		},
		{
			Option.SHOW_CREATE_SKIP_ACCT,
			typeof(bool)
		},
		{
			Option.PAGE_MOUSE_OVERS,
			typeof(int)
		},
		{
			Option.COVER_MOUSE_OVERS,
			typeof(int)
		},
		{
			Option.LAST_PRECON_HERO_CHOSEN,
			typeof(int)
		},
		{
			Option.AI_MODE,
			typeof(int)
		},
		{
			Option.TIP_PRACTICE_PROGRESS,
			typeof(int)
		},
		{
			Option.TIP_PLAY_PROGRESS,
			typeof(int)
		},
		{
			Option.TIP_FORGE_PROGRESS,
			typeof(int)
		},
		{
			Option.LAST_CUSTOM_DECK_CHOSEN,
			typeof(long)
		},
		{
			Option.SELECTED_ADVENTURE,
			typeof(int)
		},
		{
			Option.SELECTED_ADVENTURE_MODE,
			typeof(int)
		},
		{
			Option.LAST_SELECTED_STORE_BOOSTER_ID,
			typeof(int)
		},
		{
			Option.LAST_SELECTED_STORE_ADVENTURE_ID,
			typeof(int)
		},
		{
			Option.SERVER_OPTIONS_VERSION,
			typeof(int)
		},
		{
			Option.LATEST_SEEN_TAVERNBRAWL_SEASON,
			typeof(int)
		},
		{
			Option.LATEST_SEEN_TAVERNBRAWL_SEASON_CHALKBOARD,
			typeof(int)
		},
		{
			Option.LAST_SELECTED_STORE_HERO_ID,
			typeof(int)
		},
		{
			Option.TIMES_SEEN_TAVERNBRAWL_CRAZY_RULES_QUOTE,
			typeof(int)
		},
		{
			Option.SKIP_DECK_TEMPLATE_PAGE_FOR_CLASS_FLAGS,
			typeof(int)
		},
		{
			Option.SET_ROTATION_INTRO_PROGRESS,
			typeof(int)
		},
		{
			Option.TIMES_MOUSED_OVER_SWITCH_FORMAT_BUTTON,
			typeof(int)
		},
		{
			Option.RETURNING_PLAYER_BANNER_SEEN,
			typeof(int)
		},
		{
			Option.LAST_TAVERN_JOINED,
			typeof(long)
		},
		{
			Option.LATEST_SEEN_FIRESIDEBRAWL_SEASON,
			typeof(int)
		},
		{
			Option.LATEST_SEEN_FIRESIDEBRAWL_SEASON_CHALKBOARD,
			typeof(int)
		},
		{
			Option.LATEST_SEEN_SCHEDULED_DOUBLE_GOLD_VO,
			typeof(int)
		},
		{
			Option.LATEST_SEEN_SCHEDULED_ALL_POPUPS_SHOWN_VO,
			typeof(int)
		},
		{
			Option.LATEST_SEEN_SCHEDULED_ENTERED_ARENA_DRAFT,
			typeof(int)
		},
		{
			Option.LATEST_SEEN_SCHEDULED_LOGIN_FLOW_COMPLETE,
			typeof(int)
		},
		{
			Option.LATEST_SEEN_WELCOME_QUEST_DIALOG,
			typeof(int)
		},
		{
			Option.LATEST_SEEN_ARENA_SEASON_STARTING,
			typeof(int)
		},
		{
			Option.LATEST_SEEN_ARENA_SEASON_ENDING,
			typeof(int)
		},
		{
			Option.LATEST_SEEN_CURRENCY_CHANGED_VERSION,
			typeof(int)
		},
		{
			Option.LATEST_SEEN_SCHEDULED_WELCOME_QUEST_SHOWN_VO,
			typeof(int)
		},
		{
			Option.LATEST_SEEN_SCHEDULED_GENERIC_REWARD_SHOWN_VO,
			typeof(int)
		},
		{
			Option.LAST_SELECTED_STORE_PACK_TYPE,
			typeof(int)
		},
		{
			Option.LATEST_SEEN_SCHEDULED_ARENA_REWARD_SHOWN_VO,
			typeof(int)
		},
		{
			Option.WHIZBANG_POPUP_COUNTER,
			typeof(int)
		},
		{
			Option.SET_ROTATION_INTRO_PROGRESS_NEW_PLAYER,
			typeof(int)
		},
		{
			Option.FORMAT_TYPE,
			typeof(int)
		},
		{
			Option.FORMAT_TYPE_LAST_PLAYED,
			typeof(int)
		}
	};

	public static readonly Map<Option, object> s_defaultsMap = new Map<Option, object>
	{
		{
			Option.SOUND,
			true
		},
		{
			Option.MUSIC,
			true
		},
		{
			Option.CURSOR,
			true
		},
		{
			Option.HUD,
			true
		},
		{
			Option.STREAMING,
			true
		},
		{
			Option.SOUND_VOLUME,
			1f
		},
		{
			Option.MUSIC_VOLUME,
			1f
		},
		{
			Option.GFX_FULLSCREEN,
			true
		},
		{
			Option.GFX_QUALITY,
			1
		},
		{
			Option.IDLE_KICKER,
			true
		},
		{
			Option.IDLE_KICK_TIME,
			"30 min"
		},
		{
			Option.BACKGROUND_SOUND,
			true
		},
		{
			Option.PREFERRED_REGION,
			-1
		},
		{
			Option.NEARBY_PLAYERS,
			true
		},
		{
			Option.LOCAL_TUTORIAL_PROGRESS,
			TutorialProgress.NOTHING_COMPLETE
		},
		{
			Option.CONNECT_TO_AURORA,
			false
		},
		{
			Option.RECONNECT,
			true
		},
		{
			Option.RECONNECT_TIMEOUT,
			60f
		},
		{
			Option.RECONNECT_RETRY_TIME,
			5f
		},
		{
			Option.TOUCH_MODE,
			false
		},
		{
			Option.SHOWN_GFX_DEVICE_WARNING,
			false
		},
		{
			Option.INTRO,
			true
		},
		{
			Option.TUTORIAL_LOST_PROGRESS,
			0
		},
		{
			Option.ERROR_SCREEN,
			true
		},
		{
			Option.IKS_VIEW_ATTEMPTS,
			0
		},
		{
			Option.IKS_LAST_DOWNLOAD_TIME,
			0uL
		},
		{
			Option.IKS_LAST_DOWNLOAD_RESPONSE,
			""
		},
		{
			Option.IKS_LAST_STORED_RESPONSE,
			""
		},
		{
			Option.IKS_CACHE_AGE,
			300
		},
		{
			Option.SEEN_PACK_PRODUCT_LIST,
			""
		},
		{
			Option.CHEAT_HISTORY,
			""
		},
		{
			Option.PRELOAD_CARD_ASSETS,
			false
		},
		{
			Option.DEV_TIMESCALE,
			1f
		},
		{
			Option.IKS_LAST_SHOWN_AD,
			""
		},
		{
			Option.SHOW_STANDARD_ONLY,
			false
		},
		{
			Option.FORCE_SHOW_IKS,
			false
		},
		{
			Option.PEGUI_DEBUG,
			0
		},
		{
			Option.IS_TEMPORARY_ACCOUNT_CHEAT,
			false
		},
		{
			Option.TEMPORARY_ACCOUNT_DATA,
			""
		},
		{
			Option.DISALLOWED_CLOUD_STORAGE,
			false
		},
		{
			Option.CREATED_ACCOUNT,
			false
		},
		{
			Option.LAST_HEAL_UP_EVENT_DATE,
			0L
		},
		{
			Option.PUSH_NOTIFICATION_STATUS,
			1
		},
		{
			Option.HAS_SHOWN_DEVICE_PERFORMANCE_WARNING,
			false
		},
		{
			Option.UPDATE_STATE,
			0
		},
		{
			Option.NATIVE_UPDATE_STATE,
			""
		},
		{
			Option.ASK_UNKNOWN_APPS,
			true
		},
		{
			Option.MAX_DOWNLOAD_SPEED,
			0
		},
		{
			Option.STREAMING_SPEED_IN_GAME,
			512000
		},
		{
			Option.AUTOCONVERT_VIRTUAL_CURRENCY,
			false
		},
		{
			Option.STREAMER_MODE,
			false
		},
		{
			Option.LATEST_SEEN_SHOP_PRODUCT_LIST,
			""
		},
		{
			Option.LATEST_DISPLAYED_SHOP_PRODUCT_LIST,
			""
		},
		{
			Option.RANK_DEBUG,
			RankDebugOption.OFF
		},
		{
			Option.CRASH_COUNT,
			0
		},
		{
			Option.EXCEPTION_COUNT,
			0
		},
		{
			Option.LOW_MEMORY_COUNT,
			0
		},
		{
			Option.CLOSED_WITHOUT_CRASH,
			true
		},
		{
			Option.EXCEPTION_HASH,
			""
		},
		{
			Option.LAST_EXCEPTION_HASH,
			""
		},
		{
			Option.CRASH_IN_A_ROW_COUNT,
			0
		},
		{
			Option.SAME_EXCEPTION_COUNT,
			0
		},
		{
			Option.CELL_PROMPT_THRESHOLD,
			20971520
		},
		{
			Option.DOWNLOAD_ALL_FINISHED,
			false
		},
		{
			Option.DELAYED_REPORTER_STOP,
			false
		},
		{
			Option.HUD_CONFIG,
			""
		},
		{
			Option.HUD_SCALE,
			1f
		},
		{
			Option.ENABLED_LOG_LIST,
			""
		},
		{
			Option.HAS_SEEN_CLIPBOARD_NOTIFICATION,
			false
		},
		{
			Option.PROG_TILE_DEBUG,
			false
		},
		{
			Option.ANR_THROTTLE,
			0.01f
		},
		{
			Option.ANR_WAIT_SECONDS,
			10f
		},
		{
			Option.APP_RATING_POPUP_COUNT,
			0
		},
		{
			Option.NEWEST_REWARDED_DECK_ID,
			0L
		},
		{
			Option.SHOW_CREATE_SKIP_ACCT,
			false
		},
		{
			Option.LAST_SELECTED_STORE_PACK_TYPE,
			1
		},
		{
			Option.ASSET_DOWNLOAD_ENABLED,
			true
		},
		{
			Option.IN_RANKED_PLAY_MODE,
			true
		},
		{
			Option.SPECTATOR_OPEN_JOIN,
			true
		},
		{
			Option.SCREEN_SHAKE_ENABLED,
			true
		},
		{
			Option.LATEST_SEEN_TAVERNBRAWL_SEASON,
			0
		},
		{
			Option.LATEST_SEEN_TAVERNBRAWL_SEASON_CHALKBOARD,
			0
		},
		{
			Option.TIMES_SEEN_TAVERNBRAWL_CRAZY_RULES_QUOTE,
			0
		},
		{
			Option.SKIP_DECK_TEMPLATE_PAGE_FOR_CLASS_FLAGS,
			0
		},
		{
			Option.HAS_SEEN_WILD_MODE_VO,
			false
		},
		{
			Option.NEEDS_TO_MAKE_STANDARD_DECK,
			true
		},
		{
			Option.HAS_SEEN_INVALID_ROTATED_CARD,
			false
		},
		{
			Option.SHOW_SWITCH_TO_WILD_ON_PLAY_SCREEN,
			false
		},
		{
			Option.SHOW_SWITCH_TO_WILD_ON_CREATE_DECK,
			false
		},
		{
			Option.SHOW_WILD_DISCLAIMER_POPUP_ON_CREATE_DECK,
			true
		},
		{
			Option.HAS_SEEN_BASIC_DECK_WARNING,
			false
		},
		{
			Option.GLOW_COLLECTION_BUTTON_AFTER_SET_ROTATION,
			false
		},
		{
			Option.HAS_SEEN_RAF,
			false
		},
		{
			Option.HAS_SEEN_RAF_RECRUIT_URL,
			false
		},
		{
			Option.SHOULD_AUTO_CHECK_IN_TO_FIRESIDE_GATHERINGS,
			true
		},
		{
			Option.HAS_CLICKED_FIRESIDE_GATHERINGS_BUTTON,
			false
		},
		{
			Option.HAS_INITIATED_FIRESIDE_GATHERING_SCAN,
			false
		},
		{
			Option.LATEST_SEEN_SCHEDULED_DOUBLE_GOLD_VO,
			0
		},
		{
			Option.LATEST_SEEN_SCHEDULED_ALL_POPUPS_SHOWN_VO,
			0
		},
		{
			Option.LATEST_SEEN_SCHEDULED_ENTERED_ARENA_DRAFT,
			0
		},
		{
			Option.LATEST_SEEN_SCHEDULED_LOGIN_FLOW_COMPLETE,
			0
		},
		{
			Option.LATEST_SEEN_WELCOME_QUEST_DIALOG,
			0
		},
		{
			Option.LATEST_SEEN_ARENA_SEASON_STARTING,
			0
		},
		{
			Option.LATEST_SEEN_ARENA_SEASON_ENDING,
			0
		},
		{
			Option.LATEST_SEEN_CURRENCY_CHANGED_VERSION,
			0
		},
		{
			Option.WHIZBANG_POPUP_COUNTER,
			0
		},
		{
			Option.SET_ROTATION_INTRO_PROGRESS_NEW_PLAYER,
			0
		},
		{
			Option.FORMAT_TYPE,
			2
		},
		{
			Option.FORMAT_TYPE_LAST_PLAYED,
			2
		},
		{
			Option.HAS_SEEN_CLASSIC_MODE_VO,
			false
		}
	};
}
