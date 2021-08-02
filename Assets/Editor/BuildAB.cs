using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class BuildAB
{
	[MenuItem("Tools/BuildAssetbundle/Assets-Scenes-SampleScene")]
	static void BuildAssetbundle()
	{
		string outPath = Path.Combine(Application.streamingAssetsPath);

		//如果目录已经存在删除它
		if (Directory.Exists(outPath))
		{
			Directory.Delete(outPath, true);
		}
		Directory.CreateDirectory(outPath);

		List<AssetBundleBuild> builds = new List<AssetBundleBuild>();
		//设置bundle名，和多少资源打在同一个Bundle内
		builds.Add(new AssetBundleBuild() { assetBundleName = "ab-main.unity3d", assetNames = new string[] { @"Assets\Main.unity" } });
		//构建Assetbundle
		BuildPipeline.BuildAssetBundles(outPath, builds.ToArray(), BuildAssetBundleOptions.None | BuildAssetBundleOptions.DeterministicAssetBundle, BuildTarget.StandaloneWindows64);
		//刷新
		AssetDatabase.Refresh();

		Debug.Log("创建完毕");
	}
}
