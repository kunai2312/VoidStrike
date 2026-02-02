using UnityEditor.Callbacks;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speedBullet;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = Vector2.up * speedBullet;
        Destroy(gameObject, 3f);

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }



}
