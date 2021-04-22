using UnityEngine;
using System.Collections;
 
public class CameraRotateScene2 : MonoBehaviour 
{
    public float x = 0;
    public float y = 0;
    public float z = 0;

    private Vector3 rotateValue;

    private float move = 0;
    private float temp = 0;

    public float velocity = 0;

    void Start()
    {
        temp = y;
        StartCoroutine(First());
    }

    void Update()
    {
        rotateValue = new Vector3(x, y, z);
        transform.eulerAngles = transform.eulerAngles - rotateValue;

        if(move == 1)
        {
            y = 0;
            transform.position += transform.forward * velocity * Time.deltaTime;
            Debug.Log("transform");
        }
    }

    System.Collections.IEnumerator First()
    {
        yield return new WaitForSeconds(4);
        move = 1;
        Debug.Log("After move true");


        yield return new WaitForSeconds(1); 
        y = temp;
        move = 0;
        Debug.Log("after move false again");

        yield return new WaitForSeconds(2);
        y = y / 2;


    }
}   