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
            // Find the timer and save the remaining time
            GameTimer timer = FindFirstObjectByType<GameTimer>();
            if (timer != null)
            {
                GameTimer.finalTime = timer.timeRemaining;
            }

            SceneManager.LoadScene("WinScene");
        }
    }
}