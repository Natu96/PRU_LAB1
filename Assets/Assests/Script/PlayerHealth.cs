using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable
{
    public float maxHealth = 100f;
    public float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        Debug.Log($"Player took {amount} damage. Current HP: {currentHealth}");

        if (currentHealth <= 0f)
        {
            Die();
            FindObjectOfType<GameOverManager>().ShowGameOver();

        }
    }

    void Die()
    {
        Debug.Log("Player died!");
        currentHealth = 0f;
        Destroy(gameObject);
    }
}
