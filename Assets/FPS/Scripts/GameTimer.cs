using UnityEngine;
using TMPro;
using Unity.FPS.Game;
using System.Collections.Generic;

public class GameTimer : MonoBehaviour
{
    public float timeRemaining = 120f;
    public TextMeshProUGUI timerText;
    public Health playerHealth;
    public static float finalTime;   // <-- time saved for WinScene
    public static List<float> completedTimes = new List<float>();

    bool timerEnded = false;

    void Update()
    {
        if (timerEnded)
            return;

        if (timeRemaining > 0f)
        {
            timeRemaining -= Time.deltaTime;
            timeRemaining = Mathf.Max(timeRemaining, 0f);
            UpdateTimerDisplay();
        }

        if (timeRemaining == 0f && !timerEnded)
        {
            timerEnded = true;
            playerHealth.Kill();   // <-- removes all HP
        }
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60f);
        int seconds = Mathf.FloorToInt(timeRemaining % 60f);
        timerText.text = $"{minutes:00}:{seconds:00}";
    }

    public void SaveTime()
    {
        finalTime = timeRemaining;
    }
}