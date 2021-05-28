using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Shoot : MonoBehaviour
{

    public int bullets = 6;
    public GameObject bulletCount;
    public Sprite[] mySprites;
    bool reloading = false;

    public float timeLeft = 10;
    public Text countdown;

    // Start is called before the first frame update
    void Start()
    {
        bulletCount.GetComponent<Image>().sprite = mySprites[bullets];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r") && reloading == false && bullets < 6)
        {
            reloading = true;
            ReloadBullets();
        }
        if (Input.GetMouseButtonDown(0) && reloading == false && bullets > 0) 
        {
            Shooted();
        } /*else if (Input.GetMouseButtonDown(0) && reloading == true)
        {
            reloading = false;
        }*/
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            countdown.text = ((int) timeLeft).ToString();
        } else if (timeLeft == 0)
        {
            //EndGame
        }
    }

    public void Shooted()
    {
        bullets = bullets - 1;
        bulletCount.GetComponent<Image>().sprite = mySprites[bullets];
    }

    void ReloadBullets()
    {
        StartCoroutine(Reload());
    }

    IEnumerator Reload()
    {
        while (bullets < 6 && reloading == true)
        {
            yield return new WaitForSeconds(0.3f);
            bullets = bullets + 1;
            bulletCount.GetComponent<Image>().sprite = mySprites[bullets];
        }
        reloading = false;
    }
}