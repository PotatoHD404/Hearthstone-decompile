public enum GameLayer
{
	Default = 0,
	TransparentFX = 1,
	IgnoreRaycast = 2,
	Water = 4,
	UI = 5,
	CardRaycast = 8,
	DragPlane = 9,
	PlayAreaCollision = 10,
	InvisibleHitBox1 = 11,
	InvisibleHitBox2 = 12,
	BackgroundUI = 13,
	Tooltip = 14,
	ScrollRaycast = 0xF,
	InvisibleHitBox3 = 0x10,
	PerspectiveUI = 17,
	BattleNet = 18,
	IgnoreFullScreenEffects = 19,
	NoLight = 20,
	Effects = 21,
	FXCollide = 22,
	ScreenEffects = 23,
	BattleNetFriendList = 24,
	BattleNetChat = 25,
	BattleNetDialog = 26,
	HighPriorityUI = 27,
	InvisibleRender = 28,
	Reserved29 = 29,
	CameraFade = 30,
	CameraMask = 0x1F
}
