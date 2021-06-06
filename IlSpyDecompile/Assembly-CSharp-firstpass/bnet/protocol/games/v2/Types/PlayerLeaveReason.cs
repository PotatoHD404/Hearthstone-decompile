namespace bnet.protocol.games.v2.Types
{
	public enum PlayerLeaveReason
	{
		PLAYER_LEAVE_REASON_PLAYER_REMOVED_BY_GAME_SERVER,
		PLAYER_LEAVE_REASON_GAME_ENDED_BY_GAME_SERVER,
		PLAYER_LEAVE_REASON_PLAYER_DISCONNECTED_FROM_GAME_SERVER,
		PLAYER_LEAVE_REASON_GAME_SERVER_DISCONNECTED_FROM_SERVICE,
		PLAYER_LEAVE_REASON_PLAYER_HOST_DISCONNECTED_FROM_SERVICE,
		PLAYER_LEAVE_REASON_GAME_MASTER_DISCONNECTED_FROM_SERVICE,
		PLAYER_LEAVE_REASON_NONE
	}
}
