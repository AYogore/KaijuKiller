using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUI : MonoBehaviour
{
    public Text timeText;
    private float timer;
    void Start()
    {
        DisplayTime(0);
    }

    // Update is called once per frame
    void Update()
    {
        DisplayTime(timer += Time.deltaTime);
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
