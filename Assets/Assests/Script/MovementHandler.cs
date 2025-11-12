using UnityEngine;
using UnityEngine.EventSystems;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 1f;
    private Rigidbody2D rbody;
    private Vector2 direction;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        direction = new Vector2(moveX, moveY).normalized;
    }
    private void FixedUpdate()
    {
        rbody.linearVelocity = direction * moveSpeed;
    }
}

