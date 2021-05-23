

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief 設定。
*/


/** Setting
*/
public class Setting
{
	/** AUTHOR_NAME
	*/
	public const string AUTHOR_NAME = "BlueBack";

	/** AUTHOR_URL
	*/
	public const string AUTHOR_URL = "https://github.com/bluebackblue";

	/** PACKAGE_NAME
	*/
	public const string PACKAGE_NAME = "TimeScale";

	/** PACKAGEJSON
	*/
	public const string PACKAGEJSON_UNITY = "2020.1";

	/** PACKAGEJSON
	*/
	public const string PACKAGEJSON_DISCRIPTION = "タイムスケール操作";

	/** PACKAGEJSON
	*/
	public static readonly string[] PACKAGEJSON_KEYWORD = new string[]{
		"time"
	};

	/** CHANGELOG
	*/
	public static string[] CHANGELOG = new string[]{
		"# Changelog",
		"",

		/*
		"## [0.0.0] - 0000-00-00",
		"### Changes",
		"- Init",
		"",
		*/

		"## [0.0.1] - 2021-05-23",
		"### Changes",
		"- Init",
		"",
	};

	/** GetPackageVersion
	*/
	public static string GetPackageVersion()
	{
		return BlueBack.TimeScale.Version.packageversion;
	}

	/** ReadmeMd_StringCreator_Argument
	*/
	public struct ReadmeMd_StringCreator_Argument
	{
		public string version;
	}

	/** ReadmeMd_StringCreator_Type
	*/
	public delegate string[] ReadmeMd_StringCreator_Type(in ReadmeMd_StringCreator_Argument a_argument);

	/** READMEMD_STRINGCREATOR
	*/
	public static readonly ReadmeMd_StringCreator_Type[] READMEMD_STRINGCREATOR = new ReadmeMd_StringCreator_Type[]{

		/** 概要。
		*/
		(in ReadmeMd_StringCreator_Argument a_argument) => {
			return new string[]{
				"# " + AUTHOR_NAME + "." + PACKAGE_NAME,
				"タイムスケール操作",
				"* 停止、再開、ステップ再生",
			};
		},

		/** ライセンス。
		*/
		(in ReadmeMd_StringCreator_Argument a_argument) => {
			return new string[]{
				"## ライセンス",
				"MIT License",
				"* " + AUTHOR_URL + "/" + PACKAGE_NAME + "/blob/main/LICENSE",
			};
		},

		/** 依存。
		*/
		(in ReadmeMd_StringCreator_Argument a_argument) => {
			return new string[]{
				"## 外部依存 / 使用ライセンス等",
				"* " + AUTHOR_URL + "/" + "UnityPlayerLoop",
				//"### サンプルのみ",
				//"* " + AUTHOR_URL + "/" + "AssetLib",
			};
		},

		/** 動作確認。
		*/
		(in ReadmeMd_StringCreator_Argument a_argument) => {
			return new string[]{
				"## 動作確認",
				"Unity " + UnityEngine.Application.unityVersion,
			};
		},

		/** UPM。
		*/
		(in ReadmeMd_StringCreator_Argument a_argument) => {
			return new string[]{
				"## UPM",
				"### 最新",
				"* " + AUTHOR_URL + "/" + PACKAGE_NAME + ".git?path=unity_" + PACKAGE_NAME + "/Assets/UPM#" + a_argument.version,
				"### 開発",
				"* " + AUTHOR_URL + "/" + PACKAGE_NAME + ".git?path=unity_" + PACKAGE_NAME + "/Assets/UPM",
			};
		},

		/** インストール。 
		*/
		(in ReadmeMd_StringCreator_Argument a_argument) => {
			return new string[]{
				"## Unityへの追加方法",
				"* Unity起動",
				"* メニュー選択：「Window->Package Manager」",
				"* ボタン選択：「左上の＋ボタン」",
				"* リスト選択：「Add package from git URL...」",
				"* 上記UPMのURLを追加「 https://github.com/～～/UPM#バージョン 」",
				"### 注",
				"Gitクライアントがインストールされている必要がある。",
				"* https://docs.unity3d.com/ja/current/Manual/upm-git.html",
				"* https://git-scm.com/",
			};
		},

		/** 例。
		*/
		(in ReadmeMd_StringCreator_Argument a_argument) => {
			return new string[]{

				#if(false)

				"## 例",

				"```",
				"",
				"/** Start",
				"*/",
				"private void Start()",
				"{",
				"}",
				"",
				"/** Update",
				"*/",
				"private void Update()",
				"{",
				"}",
				"",
				"/** FixedUpdate",
				"*/",
				"private void FixedUpdate()",
				"{",
				"}",

				"```",

				#endif
			};
		},
	};
}

