using JetBrains.Annotations;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject[] weapon;
    public GameObject[] bullet;
    public Transform spawnBullet;

    public float fireRate = 0.5f;
    public enum WeaponModel
    {
        Rocket,
        Cannon,
        Laze,

    }
    public WeaponModel thisWeaponModel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("shoot", 0f, fireRate);
    }
    void Update()
    {
        if (thisWeaponModel == WeaponModel.Rocket)
        {
            weapon[0].gameObject.SetActive(true);
        }
        if (thisWeaponModel == WeaponModel.Cannon)
        {
            weapon[1].gameObject.SetActive(true);
        }
        if (thisWeaponModel == WeaponModel.Laze)
        {
            weapon[2].gameObject.SetActive(true);
        }
    }
    void shoot()
    {
        if (thisWeaponModel == WeaponModel.Rocket)
        {
            Instantiate(bullet[0], spawnBullet.position, Quaternion.identity);
        }
        if (thisWeaponModel == WeaponModel.Cannon)
        {
            Instantiate(bullet[1], spawnBullet.position, Quaternion.identity);
        }
        if (thisWeaponModel == WeaponModel.Laze)
        {
            Instantiate(bullet[2], spawnBullet.position, Quaternion.identity);
        }

    }


}
