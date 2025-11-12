using UnityEngine;

public class Meteorite : MonoBehaviour, IDamageable
{
    public float hp = 100f;
    public float timer = 4f;
    public float moveSpeed = 3f;
    private Vector2 moveDirection;
    public GameObject starPrefab;
    void Start()
    {
        // Pick a random angle between -45 and 45 degrees downward
        float angle = Random.Range(-45f, 45f);
        float radians = angle * Mathf.Deg2Rad;

        // Calculate direction vector based on angle
        moveDirection = new Vector2(Mathf.Sin(radians), -Mathf.Cos(radians)).normalized;

        // Destroy after timer
        Destroy(gameObject, timer);
    }

    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

    public void TakeDamage(float amount)
    {
        hp -= amount;

        if (hp <= 0f)
        {
            DropStar();
            Destroy(gameObject);
        }
    }
    void DropStar()
    {
        if (starPrefab != null)
        {
            Instantiate(starPrefab, transform.position, Quaternion.identity);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            IDamageable player = other.GetComponent<IDamageable>();
            if (player != null)
            {
                player.TakeDamage(25f);
            }
            DropStar();
            Destroy(gameObject);
        }
    }
  
}
