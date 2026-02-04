using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; set; }
    public TextMeshProUGUI scoreText;
    public int score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Instance = this;
    }
    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Score: " + score;
    }
}
