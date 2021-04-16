using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public float time = 0;
    public float nextSceneNum = 0;

    void Start()
    {
        // coroutine

        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(time);
        nextScene();
    }



    public void nextScene()
    {
        SceneManager.LoadScene("Scene " + nextSceneNum);
    }
}
