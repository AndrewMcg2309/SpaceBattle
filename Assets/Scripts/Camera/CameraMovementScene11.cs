using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScene11 : MonoBehaviour
{
    public float speed = 0;
    public float time = 0;
    public float timeToExplsion = 0;

    public float timeToTurn = 0;
    public float timeToFinishTurn = 0;
    bool shoot = false;
    bool turn = false;

    void Start()
    {
        StartCoroutine(Wait());
        StartCoroutine(WaitTurn());
    }

    System.Collections.IEnumerator Wait()
    {
        yield return new WaitForSeconds(time);
        shoot = true;

        yield return new WaitForSeconds(timeToExplsion);
        shoot = false;
    }

    System.Collections.IEnumerator WaitTurn()
    {
        yield return new WaitForSeconds(timeToTurn);
        turn = true;

        yield return new WaitForSeconds(timeToFinishTurn);
        turn = false;
    }

    void Update()
    {
        if(shoot)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        if(turn)
        {
            
        }
    }


    // 2 seconds to blow up

    // rotate y by -45 to aim at person
}