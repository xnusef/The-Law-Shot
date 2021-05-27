using UnityEngine;

public class HoverAndClick : MonoBehaviour
{
    /*public AudioSource fx;
    public AudioClip hover;
    public AudioClip click;*/
    public GameObject ShownImage;
    public GameObject buttonImage1;
    public GameObject buttonImage2;
    public GameObject button;

    public void OnClick()
    {
        if(!ShownImage.activeSelf)
        {
            ShownImage.SetActive(true);
            buttonImage2.SetActive(false);
            buttonImage1.SetActive(false);
        } else if(ShownImage.activeSelf)
        {
            ShownImage.SetActive(false);
        }
    }
    public void HoverEnd()
    {
       ShownImage.SetActive(false); 
    }
}
