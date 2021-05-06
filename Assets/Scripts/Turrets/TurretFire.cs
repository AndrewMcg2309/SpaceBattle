using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFire : MonoBehaviour
{
    public float distance = 0;
    public float fireRate = 0;

    public float timeToStart = 0;
    public float timeToReturn = 0;
    public float timeToRepeat = 0;
    public float mainWait = 0;

    bool fire = false;
    bool returning = false;

    public float velocity = 0;

    Vector3 firing = new Vector3(5, 5, 5);
    
    void Start()
    {
        StartCoroutine(Fire());
    }

    
    void Update()
    {
        if(fire == true)
        {
            transform.position += transform.forward * velocity * Time.deltaTime;
        }   
        if(returning == true)
        {
            transform.position += transform.forward * -velocity * Time.deltaTime;
        }
    }

    System.Collections.IEnumerator Fire()
    {
        yield return new WaitForSeconds(mainWait);
        while(true)
        {
            yield return new WaitForSeconds(timeToStart);
            fire = true;
            returning = false;

            yield return new WaitForSeconds(timeToReturn);
            fire = false;
            returning = true;

            yield return new WaitForSeconds(timeToRepeat);
            returning = false;
        }
        
    }
}
