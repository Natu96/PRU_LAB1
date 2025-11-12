using UnityEngine;
using UnityEngine.UI;

public class HealthbarUi : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Image healthFillImage;

    void Update()
    {
        if (playerHealth != null && healthFillImage != null)
        {
            float fill = playerHealth.currentHealth / playerHealth.maxHealth;
            healthFillImage.fillAmount = Mathf.Clamp01(fill);
        }
        else if (healthFillImage != null)
        {
            healthFillImage.fillAmount = 0f;
        }
    }
}
