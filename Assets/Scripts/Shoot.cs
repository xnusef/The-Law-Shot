using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Shoot : MonoBehaviour
{

    public int bullets = 6;
    public GameObject bulletCount;
    public Sprite[] mySprites;
    bool reloading = false;

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
        }
    }

    public void Shooted()
    {
        bullets = bullets - 1;
        bulletCount.GetComponent<Image>().sprite = mySprites[bullets];

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            if (hitInfo.collider.gameObject.tag == "ClickArea")
            {
                Debug.Log(hitInfo.transform.name);
            }
        }



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