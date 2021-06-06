using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets the name of a Game Object and stores it in a String Variable.")]
	public class GetName : FsmStateAction
	{
		[RequiredField]
		public FsmGameObject gameObject;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString storeName;

		public bool everyFrame;

		public override void Reset()
		{
			gameObject = new FsmGameObject
			{
				UseVariable = true
			};
			storeName = null;
			everyFrame = false;
		}

		public override void OnEnter()
		{
			DoGetGameObjectName();
			if (!everyFrame)
			{
				Finish();
			}
		}

		public override void OnUpdate()
		{
			DoGetGameObjectName();
		}

		private void DoGetGameObjectName()
		{
			GameObject value = gameObject.Value;
			storeName.Value = ((value != null) ? value.name : "");
		}
	}
}
