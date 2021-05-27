using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Shoot : MonoBehaviour
{

    public int bullets = 6;
    public GameObject bulletCount;
    public Sprite b0;
    public Sprite b1;
    public Sprite b2;
    public Sprite b3;
    public Sprite b4;
    public Sprite b5;
    public Sprite b6;
    public Sprite[] mySprites;
    bool reloading = false;

    // Start is called before the first frame update
    void Start()
    {
        mySprites = new Sprite[7];
        mySprites[0] = b0;
        mySprites[1] = b1;
        mySprites[2] = b2;
        mySprites[3] = b3;
        mySprites[4] = b4;
        mySprites[5] = b5;
        mySprites[6] = b6;
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