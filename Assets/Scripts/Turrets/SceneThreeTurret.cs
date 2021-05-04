using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneThreeTurret : MonoBehaviour
{
    public float timeStart = 0;
    public bool readyToStart = false;
    //float difference = 0.5677986f;
    Vector3 ChangePosY = new Vector3(0, 0.5677986f, 0);
    public float raiseSpeed = 0;

    void Start()
    {
        StartCoroutine(StartMovement());
    }

    System.Collections.IEnumerator StartMovement()
    {
        yield return new WaitForSeconds(timeStart);  
        readyToStart = true; 
    }

    void Update()
    {
        if(readyToStart)
        {
            TurretMovement();
        }
    }

    void TurretMovement()
    {
        transform.position += ChangePosY * raiseSpeed * Time.deltaTime;
    }
}
