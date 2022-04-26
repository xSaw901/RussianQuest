using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public int sceneID;
    public Slider loadslider;

    private void Start()
    {
        StartCoroutine(LoadNextScene());
    }
    IEnumerator LoadNextScene()
    {
        AsyncOperation oper = SceneManager.LoadSceneAsync(sceneID);
        while(!oper.isDone)
        {
            float progress = oper.progress / 0.9f;
            loadslider.value = progress;
            yield return null;
        }
    }
}
