using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.FPS.Gameplay;

public class WinTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerCharacterController player = other.GetComponent<PlayerCharacterController>();

        if (player != null)
        {
            GameTimer timer = FindFirstObjectByType<GameTimer>();

            if (timer != null)
            {
                GameTimer.finalTime = timer.timeRemaining;
                GameTimer.completedTimes.Add(timer.timeRemaining);
            }

            SceneManager.LoadScene("WinScene");
        }
    }
}