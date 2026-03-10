using UnityEngine;
using TMPro;

public class DisplayFinalTime : MonoBehaviour
{
    public TextMeshProUGUI finalTimeText;

    void Start()
    {
        float time = GameTimer.finalTime;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);

        finalTimeText.text = "Time Remaining: " + 
            string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}