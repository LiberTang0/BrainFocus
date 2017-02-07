using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    private float countdownTime = 1000f;
    public Text timerText;

    // Use this for initialization
    void Start()
    {
        timerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        countdownTime = countdownTime - Time.deltaTime;
        print(countdownTime);
    }
}
