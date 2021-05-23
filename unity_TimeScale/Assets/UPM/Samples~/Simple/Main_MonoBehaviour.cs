

/** Samples.Mouse.Simple
*/
namespace Samples.Mouse.Simple
{
	/** Main_MonoBehaviour
	*/
	public class Main_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		#if(false)

		/** Update用。
		*/
		private BlueBack.Mouse.Mouse mouse;

		/** FixedUpdate用。
		*/
		private BlueBack.Mouse.Mouse mouse_fixedupdate;

		/** Start
		*/
		private void Start()
		{
			//Update用。
			this.mouse = new BlueBack.Mouse.Mouse(BlueBack.Mouse.Mode.Update,new BlueBack.Mouse.Param());

			//FixedUpdate用。
			this.mouse_fixedupdate = new BlueBack.Mouse.Mouse(BlueBack.Mouse.Mode.FixedUpdate,new BlueBack.Mouse.Param());
		}

		/** Update
		*/
		private void Update()
		{
			if(this.mouse.left.down == true){
				UnityEngine.Debug.Log("Update.Left.Down");
			}
		}

		/** FixedUpdate
		*/
		private void FixedUpdate()
		{
			if(this.mouse_fixedupdate.left.down == true){
				UnityEngine.Debug.Log("FixedUpdate.Left.Down");
			}
		}

		#endif
	}
}

