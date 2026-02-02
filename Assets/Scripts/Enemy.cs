using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speedEnemy;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = Vector2.down * speedEnemy;
        Destroy(gameObject, 3f);
    }
}
