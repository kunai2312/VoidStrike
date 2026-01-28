using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnBullet;
    public float fireRate = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("shoot", 0f, fireRate);
    }
    void shoot()
    {
        Instantiate(bulletPrefab, spawnBullet.position, Quaternion.identity);
    }


}
