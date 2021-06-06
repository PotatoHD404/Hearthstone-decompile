using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Gets the focused state of a UI InputField component.")]
	public class UiInputFieldGetIsFocused : ComponentAction<InputField>
	{
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the UI InputField component.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the is focused flag value of the UI InputField component.")]
		public FsmBool isFocused;

		[Tooltip("Event sent if inputField is focused")]
		public FsmEvent isfocusedEvent;

		[Tooltip("Event sent if nputField is not focused")]
		public FsmEvent isNotFocusedEvent;

		private InputField inputField;

		public override void Reset()
		{
			isFocused = null;
			isfocusedEvent = null;
			isNotFocusedEvent = null;
		}

		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(gameObject);
			if (UpdateCache(ownerDefaultTarget))
			{
				inputField = cachedComponent;
			}
			DoGetValue();
			Finish();
		}

		private void DoGetValue()
		{
			if (!(inputField == null))
			{
				isFocused.Value = inputField.isFocused;
				base.Fsm.Event(inputField.isFocused ? isfocusedEvent : isNotFocusedEvent);
			}
		}
	}
}
