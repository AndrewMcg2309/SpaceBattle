using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateShip : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;

    void Update()
    {
        this.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
        this.transform.Rotate(xAngle, yAngle, zAngle, Space.World);
    }

    void Start()
    {
        StartCoroutine(First());
    }

    System.Collections.IEnumerator First()
    {
        yield return new WaitForSeconds(4);
        xAngle = 0.02f;
        yAngle = -0.02f;
        zAngle = -0.02f;

        yield return new WaitForSeconds(6);
        xAngle = 0f;
        yAngle = 0f;
        zAngle = 0f;
    }
}
