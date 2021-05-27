using UnityEngine;

public class HoverAndClick : MonoBehaviour
{
    public AudioSource fx;
    public AudioClip hover;
    public AudioClip click;

    public void OnClick()
    {
        fx.PlayOneShot(click);
    }
    public void Hover()
    {
       fx.PlayOneShot(hover);
    }
}
