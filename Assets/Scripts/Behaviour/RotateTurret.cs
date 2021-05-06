using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTurret : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;

    void Update()
    {
        this.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
        
    }

    void Start()
    {
        StartCoroutine(First());
    }

    System.Collections.IEnumerator First()
    {
        yield return new WaitForSeconds(0.5f);
        yAngle = -0.07f;
        xAngle = 0.07f;



    }
}
