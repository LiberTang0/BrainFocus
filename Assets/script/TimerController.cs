using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    private float originWorkTime = 25f;
    private float originBreakTime = 5f;
    private float countdownTime;

    [SerializeField]
    private Text timerText;

    // Use this for initialization
    void Start()
    {
        timerText = GetComponent<Text>();
        countdownTime = originWorkTime * 60;
        timerText.text = originWorkTime.ToString() + ":00";
    }

    // Update is called once per frame
    void Update()
    {
        countdownTime = countdownTime - Time.deltaTime;
        int minute = Convert.ToInt32(Math.Floor(countdownTime / 60));
        float secondInFloat = countdownTime / 60 - minute;
        int second = Convert.ToInt32(Math.Floor(secondInFloat * 60));
        timerText.text = minute.ToString() + ":" + second.ToString();
    }

    public void onStart(String name)
    {
        print("Name: " + name);
    }
}
