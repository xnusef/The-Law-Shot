using System.Collections;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{

    public float timeBDestroing = 3f;

    public GameObject timer;
    private Countdown script;


    public float quitTime = 2;
    public float addTime = 3;

    bool shooted = false;

    void Start()
    {
        script = timer.GetComponent<Countdown>();
        StartCoroutine(SelfDestruction());
    }

    IEnumerator SelfDestruction()
    {
        yield return new WaitForSeconds(timeBDestroing);


        if (shooted == false)
        {
            script.ChangeTime(quitTime);
            Destroy(this.gameObject);
        }
        if (shooted == true)
        {
            script.ChangeTime(-addTime);
            Destroy(this.gameObject);
        }
        
    }

    public void Shooted()
    {
        Destroy(gameObject);
    }

}
