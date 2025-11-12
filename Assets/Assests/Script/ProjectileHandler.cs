using UnityEngine;

public class ProjectileHandler : MonoBehaviour
{
    public float projectileSpd = 10f;
    public float despawnTimer = 5f;
    public float damageAmount = 10f;

    void Start()
    {
        Destroy(gameObject, despawnTimer);
    }

    void Update()
    {
        transform.Translate(Vector2.up * projectileSpd * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        IDamageable target = other.GetComponent<IDamageable>();
        if (target != null)
        {
            target.TakeDamage(damageAmount);
            Destroy(gameObject);
        }
    }
}
