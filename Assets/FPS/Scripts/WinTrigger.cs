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
            SceneManager.LoadScene("WinScene");
        }
    }
}