using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 60f;
    public bool timerIsActive = true;
    public GameObject GameOverCanvas;
    [SerializeField] Text countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime=startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsActive)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(currentTime);
            currentTime -= 1 * Time.deltaTime;
            //countdownText.text = currentTime.ToString("Timer:0");
            countdownText.text = "Timer: " + spanTime.Minutes + " : " + spanTime.Seconds;
            if (currentTime <= 0)
            {
                currentTime = 0;
                timerIsActive = false;
                GameOverCanvas.SetActive(true);
            }
            else if (currentTime <= 10)
            {
                countdownText.color = Color.red;
            }


        }
    }
}
