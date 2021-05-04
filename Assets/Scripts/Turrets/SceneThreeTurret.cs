using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneThreeTurret : MonoBehaviour
{
    public float timeStart = 0;
    public bool readyToStart = false;
    //float difference = 0.5677986f;
    Vector3 ChangePosY = new Vector3(0, 0, 0.5677986f);
    public float raiseSpeed = 0;
    
    public float xAngle, yAngle, zAngle;

    void Start()
    {
        StartCoroutine(StartMovement());
    }

    System.Collections.IEnumerator StartMovement()
    {
        yield return new WaitForSeconds(timeStart);  
        readyToStart = true; 

        yield return new WaitForSeconds(4f);
        raiseSpeed = 0;
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

        this.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
    }
}
