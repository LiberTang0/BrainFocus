using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    private float originWorkTime = 25 * 60 * 1000f;
    private float originBreakTime = 5 * 60 * 1000f;
    private float countdownTime;


    [SerializeField]
    private Text timerText;

    // Use this for initialization
    void Start()
    {
        timerText = GetComponent<Text>();
        countdownTime = originWorkTime;
    }

    // Update is called once per frame
    void Update()
    {
        countdownTime = countdownTime - Time.deltaTime;
        timerText.text = Math.Round(countdownTime).ToString();
    }
}
