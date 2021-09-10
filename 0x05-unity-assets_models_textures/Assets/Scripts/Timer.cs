using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using System;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    private Stopwatch timer = new Stopwatch();
    float elapsedTime;
    private TimeSpan activeTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        activeTime = TimeSpan.FromSeconds(elapsedTime);
        string activeTimeStr = activeTime.ToString("mm':'ss'.'ff");
        TimerText.text = activeTimeStr;
        // TimerText.text = timer.Elapsed.Minutes + ":" + timer.Elapsed.Seconds./// ToString("00") + "." + timer.Elapsed.Milliseconds.ToString("00");
    }
}
