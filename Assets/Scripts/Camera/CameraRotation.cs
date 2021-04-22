using UnityEngine;
 using System.Collections;
 
 public class CameraRotation : MonoBehaviour 
 {
     public float x = 0;
     public float y = 0;
     public float z = 0;

     private Vector3 rotateValue;
 
     void Update()
     {
         rotateValue = new Vector3(x, y, z);
         transform.eulerAngles = transform.eulerAngles - rotateValue;
     }
 }