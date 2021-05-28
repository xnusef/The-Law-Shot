using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;
    int time = 0;

    // Update is called once per frame
    void Update()
    {
        if (time != (int) Time.time)
        {
            time = (int) Time.time;
            timer.text = time.ToString();
        }
    }
}
