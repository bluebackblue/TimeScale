

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief タイムスケール。
*/


/** BlueBack.TimeScale
*/
namespace BlueBack.TimeScale
{
	/** TimeScale
	*/
	public class TimeScale : System.IDisposable
	{
		/** 次のフレームはポーズする。
		*/
		private bool pause_request;

		/** ポーズを１フレーム解除する。
		*/
		private bool stepplay_request;

		/** 現在のタイムスケール。
		*/
		private float timescale_current;

		/** 次のフレームで設定するタイムスケール。
		*/
		private float timescale;

		/** constructor
		*/
		public TimeScale()
		{
			//PlayerLoopSystem
			UnityEngine.LowLevel.PlayerLoopSystem t_playerloopsystem = BlueBack.UnityPlayerLoop.UnityPlayerLoop.GetCurrentPlayerLoop();
			BlueBack.UnityPlayerLoop.Add.AddFromType(ref t_playerloopsystem,UnityPlayerLoop.Mode.AddFirst,typeof(UnityEngine.PlayerLoop.Initialization),typeof(PlayerLoopType.InitUpdate),this.InitUpdate);
			BlueBack.UnityPlayerLoop.Add.AddFromType(ref t_playerloopsystem,UnityPlayerLoop.Mode.AddFirst,typeof(UnityEngine.PlayerLoop.PostLateUpdate),typeof(PlayerLoopType.ApplyUpdate),this.ApplyUpdate);
			BlueBack.UnityPlayerLoop.UnityPlayerLoop.SetPlayerLoop(t_playerloopsystem);

			this.timescale = 1.0f;
			this.timescale_current = 1.0f;
			this.pause_request = false;
			this.stepplay_request = false;
		}

		/** 次のフレームで設定するタイムスケール。
		*/
		public void SetTimeScaleNextFrame(float a_timescale)
		{
			this.timescale = a_timescale;
		}

		/** 現在のタイムスケール。
		*/
		public float GetTimeScale()
		{
			return this.timescale_current;
		}

		/** 次のフレームでポーズするかどうか。
		*/
		public void SetPauseNextFrame(bool a_flag)
		{
			this.pause_request = a_flag;
		}

		/** ポーズを１フレーム解除する。
		*/
		public void StepPlay()
		{
			this.stepplay_request = true;
		}

		/** InitUpdate
		*/
		private void InitUpdate()
		{
			this.timescale_current = UnityEngine.Time.timeScale;
		}

		/** ApplyUpdate
		*/
		private void ApplyUpdate()
		{
			if(this.pause_request == true){
				if(this.stepplay_request == true){
					//次のフレームはステップ実行する。
					UnityEngine.Time.timeScale = this.timescale;
				}else{
					//次のフレームはポーズする。
					UnityEngine.Time.timeScale = 0.0f;
				}
			}else{
				//通常再生。
				UnityEngine.Time.timeScale = this.timescale;
			}

			this.stepplay_request = false;
		}

		/** [IDisposable]Dispose。
		*/
		public void Dispose()
		{
			//PlayerLoopSystem
			UnityEngine.LowLevel.PlayerLoopSystem t_playerloopsystem = BlueBack.UnityPlayerLoop.UnityPlayerLoop.GetCurrentPlayerLoop();
			BlueBack.UnityPlayerLoop.Remove.RemoveFromType(ref t_playerloopsystem,typeof(PlayerLoopType.InitUpdate));
			BlueBack.UnityPlayerLoop.Remove.RemoveFromType(ref t_playerloopsystem,typeof(PlayerLoopType.ApplyUpdate));
			BlueBack.UnityPlayerLoop.UnityPlayerLoop.SetPlayerLoop(t_playerloopsystem);
		}
	}
}

