using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Material)]
	[Tooltip("Sets a named texture in a game object's material.")]
	public class SetMaterialTexture : ComponentAction<Renderer>
	{
		[Tooltip("The GameObject that the material is applied to.")]
		[CheckForComponent(typeof(Renderer))]
		public FsmOwnerDefault gameObject;

		[Tooltip("GameObjects can have multiple materials. Specify an index to target a specific material.")]
		public FsmInt materialIndex;

		[Tooltip("Alternatively specify a Material instead of a GameObject and Index.")]
		public FsmMaterial material;

		[UIHint(UIHint.NamedTexture)]
		[Tooltip("A named parameter in the shader.")]
		public FsmString namedTexture;

		public FsmTexture texture;

		public override void Reset()
		{
			gameObject = null;
			materialIndex = 0;
			material = null;
			namedTexture = "_MainTex";
			texture = null;
		}

		public override void OnEnter()
		{
			DoSetMaterialTexture();
			Finish();
		}

		private void DoSetMaterialTexture()
		{
			string text = namedTexture.Value;
			if (text == "")
			{
				text = "_MainTex";
			}
			if (this.material.Value != null)
			{
				this.material.Value.SetTexture(text, texture.Value);
				return;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(gameObject);
			if (UpdateCache(ownerDefaultTarget))
			{
				Material material = base.renderer.GetMaterial();
				if (material == null)
				{
					LogError("Missing Material!");
				}
				else if (materialIndex.Value == 0)
				{
					material.SetTexture(text, texture.Value);
				}
				else if (base.renderer.GetMaterials().Count > materialIndex.Value)
				{
					base.renderer.GetMaterial(materialIndex.Value).SetTexture(text, texture.Value);
				}
			}
		}
	}
}
