using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationScene4 : MonoBehaviour
{
    public float x = 0;
    public float y = 0;
    public float z = 0;
    private Vector3 rotateValue;
    public float velocity;
    public float wait = 0;
    public float turningTime = 0;

    public float faceX, faceY, faceZ;
    public Transform target;
    private float forward = 0;
    public float speed = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IncreaseSpeed());
    }

    // Update is called once per frame
    void Update()
    {
        rotateValue = new Vector3(x, y, z);
        transform.eulerAngles = transform.eulerAngles - rotateValue * velocity;

        if(forward == 1)
        {
            y = 0;
            transform.position += transform.forward * speed * Time.deltaTime;
            Debug.Log("transform");
        }
    }

    System.Collections.IEnumerator IncreaseSpeed()
    {
        yield return new WaitForSeconds(wait);

        Vector3 temp = rotateValue;
        x = rotateValue.x *2;
        y = rotateValue.y *2;
        z = rotateValue.z *2;
        

        yield return new WaitForSeconds(turningTime);

        x = 0;
        y = 0;
        z = 0;
        
        LookAt();
    

        yield return new WaitForSeconds(1);

        forward = 1;

        yield return new WaitForSeconds(2);        

        forward = 0;
    }

    void LookAt()
    {
        transform.LookAt(target);
    }
}
