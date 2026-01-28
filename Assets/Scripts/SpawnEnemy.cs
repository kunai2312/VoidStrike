
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnX = Random.Range(-2.4f, 2.4f);
    public float spawnRate = 1f;

    // Update is called once per frame
    void Update()
    {
        Vector2 spawnPos = new Vector2(spawnX, 6);
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}
