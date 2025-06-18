using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    void Awake()
    {
        if (instance == null) instance = this;
        
    }
    int score = 0;
    public void AddScore(int point)
    {
        score += point;
        Debug.Log(score);
    }
}
