using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
    //�V�[�����ڍs���郁�\�b�h
    public void SceneChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}