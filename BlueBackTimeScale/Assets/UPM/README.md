# BlueBack.TimeScale
タイムスケール操作
* 停止、再開、ステップ再生

## ライセンス
MIT License
* https://github.com/bluebackblue/UpmTimeScale/blob/main/LICENSE

## 依存 / 使用ライセンス等
### ランタイム
* https://github.com/bluebackblue/UpmUnityPlayerLoop
* https://github.com/bluebackblue/UpmDebug
### エディター
* https://github.com/bluebackblue/UpmVersionManager
### サンプル
* https://github.com/bluebackblue/UpmTimeScale

## 動作確認
Unity 2022.1.0b16

## UPM
### 最新
* https://github.com/bluebackblue/UpmTimeScale.git?path=BlueBackTimeScale/Assets/UPM#0.0.20
### 開発
* https://github.com/bluebackblue/UpmTimeScale.git?path=BlueBackTimeScale/Assets/UPM

## Unityへの追加方法
* Unity起動
* メニュー選択：「Window->Package Manager」
* ボタン選択：「左上の＋ボタン」
* リスト選択：「Add package from git URL...」
* 上記UPMのURLを追加「 https://github.com/～～/UPM#バージョン 」
### 注
Gitクライアントがインストールされている必要がある。
* https://docs.unity3d.com/ja/current/Manual/upm-git.html
* https://git-scm.com/

## 例
```cs
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
```

