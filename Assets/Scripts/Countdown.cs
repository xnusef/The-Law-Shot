using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    public static float timeLeft = 15f;
    float timenow;
    
    public Text countdown;

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            countdown.text = ((int) timeLeft).ToString();
        } else if (timeLeft < 0)
        {
            countdown.text = ("0");
            //EndGame
        }
    }

    public void ChangeTime(float time)
    {
        timeLeft -= time;
    }
}