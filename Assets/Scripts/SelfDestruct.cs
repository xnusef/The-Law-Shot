using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{

    public float timeBDestroing = 3f;


    void Start()
    {

        StartCoroutine(SelfDestruction());
    }

    IEnumerator SelfDestruction()
    {
        yield return new WaitForSeconds(timeBDestroing);

        Destroy(gameObject);
    }

    public void Shooted()
    {
        Destroy(gameObject);
    }

}
