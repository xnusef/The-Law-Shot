using System.Globalization;
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

        Destroy(this.gameObject);
    }

    public void Shooted()
    {
        Destroy(gameObject);
    }

}
