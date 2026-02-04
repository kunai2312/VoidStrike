using System.Xml.Serialization;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private Rigidbody2D rb;
    float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = EnemyManager.Instance.speedEnemy;

    }

    // Update is called once per frame
    void Update()
    {

        rb.linearVelocity = Vector2.down * speed;
        Destroy(gameObject, 3f);
    }
}
