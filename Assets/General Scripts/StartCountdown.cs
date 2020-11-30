using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class StartCountdown : MonoBehaviour
{
    public Text timer;
    static public bool beginning=false;

    // Start is called before the first frame update
    void Start()
    {
        if (beginning == false)
        {
            GlobalCountDown.StartCountDown(TimeSpan.FromMinutes(2));
            beginning = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        int timeToDisplay = GlobalCountDown.TimeLeft.Seconds;
        int minutes = GlobalCountDown.TimeLeft.Minutes;
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);


        if (GlobalCountDown.TimeLeft <= TimeSpan.Zero)
        {
            GlobalCountDown.timeOver = true;
            timer.text = "00:00";
        }
        else
        {
            timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}
