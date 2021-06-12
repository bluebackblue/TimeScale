# BlueBack.TimeScale
タイムスケール操作
* 停止、再開、ステップ再生

## ライセンス
MIT License
* https://github.com/bluebackblue/TimeScale/blob/main/LICENSE

## 外部依存 / 使用ライセンス等
* https://github.com/bluebackblue/UnityPlayerLoop

## 動作確認
Unity 2020.2.0b14

## UPM
### 最新
* https://github.com/bluebackblue/TimeScale.git?path=unity_TimeScale/Assets/UPM#0.0.4
### 開発
* https://github.com/bluebackblue/TimeScale.git?path=unity_TimeScale/Assets/UPM

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
```

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

```

