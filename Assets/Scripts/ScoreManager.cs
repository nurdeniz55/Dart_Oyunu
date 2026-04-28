using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }
    int score=0;
    int finalScore=0;
    float timeScore = 100;
    float time;
    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        timeScore -= Time.deltaTime;
    }
    public void AddScore(int addscore)
    {
        score += addscore;
    }
    public int getScore()
    {
        finalScore = score + (int)timeScore;
        return finalScore;
    }
}
