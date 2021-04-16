using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    void Start()
    {
        // coroutine

        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(5);
        nextScene();
    }



    public void nextScene()
    {
        SceneManager.LoadScene("Scene 2");
    }
}
