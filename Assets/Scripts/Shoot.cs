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
    //public Sprite[] mySprites;

    /*    b0,
        b1,
        b2,
        b3,
        b4,
        b5,
        b6
    };*/
    bool reloading = false;




    // Start is called before the first frame update
    void Start()
    {
        //mySprites = {b0,b1,b2,b3,b4,b5,b6};
        bulletCount.GetComponent<Image>().sprite = b6;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r") && reloading == false)
        {
            reloading = true;
            ReloadBullets();
        }
        if (Input.GetMouseButtonDown(0) && reloading == false && bullets > 0) 
        {
            Bullets();
        } else if (Input.GetMouseButtonDown(0) && reloading == true)
        {
            reloading = false;
        }
    }

    public void Bullets()
    {
        bullets = bullets - 1;
        bulletCount.GetComponent<Image>().sprite = b5;
        /*if (bullets == 5)
        {
            bulletCount.GetComponent<Image>().sprite = b5;
        }
        if (bullets == 4)
        {
            bulletCount.GetComponent<Image>().sprite = b4;
        }
        if (bullets == 3)
        {
            bulletCount.GetComponent<Image>().sprite = b3;
        }
        if (bullets == 2)
        {
            bulletCount.GetComponent<Image>().sprite = b2;
        }
        if (bullets == 1)
        {
            bulletCount.GetComponent<Image>().sprite = b1;
        }
        if (bullets == 0)
        {
            bulletCount.GetComponent<Image>().sprite = b0;
        }*/
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
            if (bullets == 0)
            {
                bulletCount.GetComponent<Image>().sprite = b1;
            }
            if (bullets == 1)
            {
                bulletCount.GetComponent<Image>().sprite = b2;
            }
            if (bullets == 2)
            {
                bulletCount.GetComponent<Image>().sprite = b3;
            }
            if (bullets == 3)
            {
                bulletCount.GetComponent<Image>().sprite = b4;
            }
            if (bullets == 4)
            {
                bulletCount.GetComponent<Image>().sprite = b5;
            }
            if (bullets == 5)
            {
                bulletCount.GetComponent<Image>().sprite = b6;
            }
            bullets = bullets + 1;
        }
        reloading=false;
    }
        
}

