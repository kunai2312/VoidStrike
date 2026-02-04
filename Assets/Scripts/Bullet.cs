using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Bullet : MonoBehaviour
{
    public float speedBullet;
    public float timeDestroy;
    int[] value;
    private Rigidbody2D rb;
    void Start()
    {
        value = EnemyManager.Instance.enemyValue;

        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = Vector2.up * speedBullet;
        Destroy(gameObject, timeDestroy);

    }
    void Update()
    {



    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy1"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            ScoreManager.Instance.AddScore(value[0]);






        }

    }



}
