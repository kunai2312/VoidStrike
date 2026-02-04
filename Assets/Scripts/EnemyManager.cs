using Unity.VisualScripting;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance { get; set; }
    public float speedEnemy;
    public int[] enemyValue;
    void Awake()
    {
        Instance = this;
    }
}

