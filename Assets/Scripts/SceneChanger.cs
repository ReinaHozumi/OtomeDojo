using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
    //シーンを移行するメソッド
    public void SceneChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}