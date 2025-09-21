using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerText : MonoBehaviour
{
    public TextMeshProUGUI timerText; // Assign a UI Text (or TMP_Text) in Inspector
    public float elapsedTime = 0f;
    public float timeMultiplier = 22f;
    private bool counting = true;

    public bool isMinute;
    public bool is45min;

    public bool isTimer;

    [Space]
    public float currentTemp = 35f;
    public float speed = 5f; // how fast it rises (adjust as needed)
    public float targetTemp = 37f;

    void Update()
    {
        if (counting)
        {
            elapsedTime += Time.deltaTime * timeMultiplier;

            if (isTimer)
            {
                // Convert seconds into minutes and seconds
                int minutes = Mathf.FloorToInt(elapsedTime / 60f);
                int seconds = Mathf.FloorToInt(elapsedTime % 60f);

                // Format MM:SS
                timerText.text = string.Format("{0:0}:{1:00}", minutes, seconds);

                if (isMinute)
                {
                    // Stop at 1:00 (one hour)
                    if (minutes >= 1 && seconds >= 0)
                    {
                        counting = false;
                        timerText.text = "1:00"; // Lock display at 1:00
                    }
                }
                else if (is45min)
                {
                    // Stop at 0:45 (45 minutes)
                    if (minutes == 0 && seconds >= 45)
                    {
                        counting = false;
                        timerText.text = "0:45"; // Lock display at 1:00
                    }
                }
                else
                {
                    // Stop at 0:30 (30 minutes)
                    if (minutes == 0 && seconds >= 30)
                    {
                        counting = false;
                        timerText.text = "0:30"; // Lock display at 1:00
                    }
                }
            }
            else
            {
                if (currentTemp < targetTemp)
                {
                    // Increase temperature smoothly
                    currentTemp += Time.deltaTime * speed;

                    // Clamp so it doesn’t overshoot
                    if (currentTemp > targetTemp)
                        currentTemp = targetTemp;

                    // Display as integer (no decimals)
                    timerText.text = Mathf.FloorToInt(currentTemp).ToString() + "°C";
                }
            }
        }
    }
}
