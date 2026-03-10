using UnityEngine;
using TMPro;

public class DisplayScoreboard : MonoBehaviour
{
    public TextMeshProUGUI scoreboardText;

    void Start()
    {
        scoreboardText.text = "Best Times:\n";

        foreach (float time in GameTimer.completedTimes)
        {
            int minutes = Mathf.FloorToInt(time / 60);
            int seconds = Mathf.FloorToInt(time % 60);

            scoreboardText.text += string.Format("{0:00}:{1:00}\n", minutes, seconds);
        }
    }
}