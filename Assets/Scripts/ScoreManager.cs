using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    void Awake()
    {
        // Ensure that this object persists across scene loads
        
    }
    int score = 0;
    void AddScore(int point)
    {
        score += point;
        Debug.Log(score);
    }
}
