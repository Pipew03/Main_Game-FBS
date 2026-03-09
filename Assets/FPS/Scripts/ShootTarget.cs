using UnityEngine;
using Unity.FPS.Game;

public class ShootTarget : MonoBehaviour
{
    Health health;

    void Awake()
    {
        health = GetComponent<Health>();

        if (health != null)
        {
            health.OnDie += HandleDeath;
        }
    }

    void HandleDeath()
    {
        Destroy(gameObject);
    }
}