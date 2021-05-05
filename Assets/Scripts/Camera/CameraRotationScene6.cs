using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationScene6 : MonoBehaviour
{
    public float velocity = 0;

    void Start()
    {
        
    }
    void Update()
    {
        transform.position += transform.forward * velocity * Time.deltaTime;
    }
}
