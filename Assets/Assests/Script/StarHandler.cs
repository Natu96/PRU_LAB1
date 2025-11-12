using UnityEngine;

public class StarHandler : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float lifetime = 6f;

    void Start()
    {
        Destroy(gameObject, lifetime); // Auto destroy after lifetime
    }

    void Update()
    {
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StarData.starValue++;
            Destroy(gameObject);
        }
    }
}
