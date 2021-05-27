using UnityEngine;
using UnityEngine.UI;

public class Mute : MonoBehaviour
{
    public AudioSource buttons;
    public AudioSource music;
    public Sprite muted;
    public Sprite unmuted;
    public GameObject mutedbutton;

    public void MuteUnmute()
    {
        if (buttons.volume == 0)
        {
            buttons.volume = 1;
            music.Play();
            mutedbutton.GetComponent<Image>().sprite = unmuted;
        }else if (buttons.volume == 1)
        {
            buttons.volume = 0;
            music.Pause();
            mutedbutton.GetComponent<Image>().sprite = muted;
        }
    }
}
