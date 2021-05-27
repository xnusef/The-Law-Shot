using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

public class CreditsBack : MonoBehaviour
{
    public GameObject creditsPanel;
    public GameObject folder;
    int estado = 0;

    public Animator transition;
    public Animator music;
    public float transitiontime = 1f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
            Cursor.visible = true;
        }
    }


    public async void ChangeMenu()
    {
        if (!folder.activeSelf)
        {
            estado = 1;
        } else if (folder.activeSelf)
        {
            estado = 2;
        }

        if (creditsPanel != null)
        {
            Animator creditsAnimator = creditsPanel.GetComponent<Animator>();

            //estado = 1 -> main // estado = 2 -> credits
            if (creditsAnimator != null) 
            {
                switch (estado)
                {
                    case 1:
                        folder.SetActive(true);
                        creditsPanel.SetActive(true);
                        creditsAnimator.SetBool("IsShown", true);
                        await Task.Delay(500);
                        estado = 2;
                        
                        break;
                    case 2:
                        creditsAnimator.SetBool("IsShown", false);
                        await Task.Delay(500);
                        folder.SetActive(false);
                        creditsPanel.SetActive(false);
                        estado = 1;
                        break;
                    default:
                        Debug.Log("The int is not correct");
                    break;
                }
            }
        }
    }

    public void Play()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        folder.SetActive(true);
    }

    IEnumerator LoadLevel(int levelindex)
    {
        transition.SetTrigger("Start");
        music.SetTrigger("Start");

        yield return new WaitForSeconds(transitiontime);

        SceneManager.LoadScene(levelindex);
    }

    public void Quit()
    {
        StartCoroutine(QuitGame());
        folder.SetActive(true);
    }

    IEnumerator QuitGame()
    {
        transition.SetTrigger("Start");
        music.SetTrigger("Start");

        yield return new WaitForSeconds(transitiontime);

        Application.Quit();
    }
}
