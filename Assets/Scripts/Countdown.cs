using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    public float timeLeft = 10;
    
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
            //EndGame
        }
    }
}
