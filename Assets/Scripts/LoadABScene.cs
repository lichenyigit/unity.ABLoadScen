using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadABScene : MonoBehaviour
{
    void Start()
    {
        Screen.SetResolution(1366, 768, true);
        string path = Path.Combine(Application.streamingAssetsPath, "main-ab.unity3d");
        //加载场景Bundle
        AssetBundle.LoadFromFile(path);
        SceneManager.LoadScene("Main");
    }
}
