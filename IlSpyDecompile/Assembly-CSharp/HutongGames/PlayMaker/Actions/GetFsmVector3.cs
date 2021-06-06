using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Get the value of a Vector3 Variable from another FSM.")]
	public class GetFsmVector3 : FsmStateAction
	{
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		[RequiredField]
		[UIHint(UIHint.FsmVector3)]
		public FsmString variableName;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeValue;

		public bool everyFrame;

		private GameObject goLastFrame;

		private string fsmNameLastFrame;

		private PlayMakerFSM fsm;

		public override void Reset()
		{
			gameObject = null;
			fsmName = "";
			storeValue = null;
		}

		public override void OnEnter()
		{
			DoGetFsmVector3();
			if (!everyFrame)
			{
				Finish();
			}
		}

		public override void OnUpdate()
		{
			DoGetFsmVector3();
		}

		private void DoGetFsmVector3()
		{
			if (storeValue == null)
			{
				return;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (ownerDefaultTarget != goLastFrame || fsmName.Value != fsmNameLastFrame)
			{
				goLastFrame = ownerDefaultTarget;
				fsmNameLastFrame = fsmName.Value;
				fsm = ActionHelpers.GetGameObjectFsm(ownerDefaultTarget, fsmName.Value);
			}
			if (!(fsm == null))
			{
				FsmVector3 fsmVector = fsm.FsmVariables.GetFsmVector3(variableName.Value);
				if (fsmVector != null)
				{
					storeValue.Value = fsmVector.Value;
				}
			}
		}
	}
}
