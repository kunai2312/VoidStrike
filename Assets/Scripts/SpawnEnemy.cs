
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;

    private float spawnX;
    public float spawnRate = 1f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("SpawnE", 0f, spawnRate);
    }


    void SpawnE()
    {
        spawnX = Random.Range(-2.4f, 2.4f);

        Vector2 spawnPos = new Vector2(spawnX, 6);
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);


    }

}
