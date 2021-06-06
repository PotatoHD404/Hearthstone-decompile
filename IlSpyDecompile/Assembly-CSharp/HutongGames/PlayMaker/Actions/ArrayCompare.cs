namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if 2 Array Variables have the same values.")]
	public class ArrayCompare : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The first Array Variable to test.")]
		public FsmArray array1;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The second Array Variable to test.")]
		public FsmArray array2;

		[Tooltip("Event to send if the 2 arrays have the same values.")]
		public FsmEvent SequenceEqual;

		[Tooltip("Event to send if the 2 arrays have different values.")]
		public FsmEvent SequenceNotEqual;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Bool variable.")]
		public FsmBool storeResult;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		public override void Reset()
		{
			array1 = null;
			array2 = null;
			SequenceEqual = null;
			SequenceNotEqual = null;
		}

		public override void OnEnter()
		{
			DoSequenceEqual();
			if (!everyFrame)
			{
				Finish();
			}
		}

		private void DoSequenceEqual()
		{
			if (array1.Values != null && array2.Values != null)
			{
				storeResult.Value = TestSequenceEqual(array1.Values, array2.Values);
				base.Fsm.Event(storeResult.Value ? SequenceEqual : SequenceNotEqual);
			}
		}

		private bool TestSequenceEqual(object[] _array1, object[] _array2)
		{
			if (_array1.Length != _array2.Length)
			{
				return false;
			}
			for (int i = 0; i < array1.Length; i++)
			{
				if (!_array1[i].Equals(_array2[i]))
				{
					return false;
				}
			}
			return true;
		}
	}
}
