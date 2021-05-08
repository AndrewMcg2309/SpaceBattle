using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShip : MonoBehaviour
{

    public float timeToDestroy = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroySpaceship());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    System.Collections.IEnumerator DestroySpaceship()
    {
        yield return new WaitForSeconds(timeToDestroy);
        Destroy(gameObject);
    }
}
