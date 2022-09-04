

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief タイムスケール。
*/


/** define
*/
#if((ASMDEF_BLUEBACK_UNITYPLAYERLOOP)||(USERDEF_BLUEBACK_UNITYPLAYERLOOP))
#define ASMDEF_TRUE
#else
#warning "ASMDEF_TRUE"
#endif


/** BlueBack.TimeScale
*/
namespace BlueBack.TimeScale
{
	/** TimeScale
	*/
	public sealed class TimeScale : System.IDisposable
	{
		/** 次のフレームはポーズする。
		*/
		private bool pause_request;

		/** ステップ再生。
		*/
		private bool stepplay_request;

		/** タイムスケール。
		*/
		private float timescale_current;

		/** 次のフレームのタイムスケール。
		*/
		private float timescale;

		/** constructor
		*/
		public TimeScale()
		#if(ASMDEF_TRUE)
		{
			//PlayerLoopSystem
			UnityEngine.LowLevel.PlayerLoopSystem t_playerloopsystem = BlueBack.UnityPlayerLoop.UnityPlayerLoop.GetCurrentPlayerLoop();
			BlueBack.UnityPlayerLoop.Add.AddFromType(ref t_playerloopsystem,UnityPlayerLoop.Mode.AddFirst,typeof(UnityEngine.PlayerLoop.Initialization),typeof(PlayerLoopType.Init),this.InitUpdate);
			BlueBack.UnityPlayerLoop.Add.AddFromType(ref t_playerloopsystem,UnityPlayerLoop.Mode.AddFirst,typeof(UnityEngine.PlayerLoop.PostLateUpdate),typeof(PlayerLoopType.Apply),this.ApplyUpdate);
			BlueBack.UnityPlayerLoop.UnityPlayerLoop.SetPlayerLoop(t_playerloopsystem);
			BlueBack.UnityPlayerLoop.UnityPlayerLoop.SetDefaultPlayerLoopOnUnityDestroy();

			//timescale
			this.timescale = 1.0f;

			//timescale_current
			this.timescale_current = 1.0f;

			//pause_request
			this.pause_request = false;

			//stepplay_request
			this.stepplay_request = false;
		}
		#else
		{
		}
		#endif

		/** [IDisposable]Dispose。
		*/
		public void Dispose()
		#if(ASMDEF_TRUE)
		{
			//PlayerLoopSystem
			UnityEngine.LowLevel.PlayerLoopSystem t_playerloopsystem = BlueBack.UnityPlayerLoop.UnityPlayerLoop.GetCurrentPlayerLoop();
			BlueBack.UnityPlayerLoop.Remove.RemoveFromType(ref t_playerloopsystem,typeof(PlayerLoopType.Init));
			BlueBack.UnityPlayerLoop.Remove.RemoveFromType(ref t_playerloopsystem,typeof(PlayerLoopType.Apply));
			BlueBack.UnityPlayerLoop.UnityPlayerLoop.SetPlayerLoop(t_playerloopsystem);
		}
		#else
		{
		}
		#endif

		/** 次のフレームのタイムスケール。設定。
		*/
		public void SetNextFrameTimeScale(float a_timescale)
		{
			this.timescale = a_timescale;
		}

		/** 次のフレームのタイムスケール。取得。
		*/
		public float GetNextFrameTimeScale()
		{
			return this.timescale;
		}

		/** タイムスケール。取得。
		*/
		public float GetTimeScale()
		{
			return this.timescale_current;
		}

		/** ポーズ。
		*/
		public void SetPause(bool a_flag)
		{
			this.pause_request = a_flag;
		}

		/** ステップ再生。
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
	}
}

