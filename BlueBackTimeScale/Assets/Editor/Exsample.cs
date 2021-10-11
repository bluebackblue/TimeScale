

/** Editor
*/
namespace Editor
{
	//<<COMMENT>>## 例

	//<<BLOACKSTART>>
	/** ポーズ。ステップ再生。
	*/
	public sealed class Exsample : UnityEngine.MonoBehaviour
	{
		/** timescale
		*/
		private BlueBack.TimeScale.TimeScale timescale;

		/** Start
		*/
		private void Start()
		{
			//timescale
			this.timescale = new BlueBack.TimeScale.TimeScale();
		}

		/** Update
		*/
		private void Update()
		{
			//ポーズ。
			if(UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.Space) == true){
				this.timescale.SetPause(true);
			}

			//ステップ再生。
			if(UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.Return) == true){
				this.timescale.StepPlay();
			}
		}
	}
	//<<BLOACKEND>>
}

