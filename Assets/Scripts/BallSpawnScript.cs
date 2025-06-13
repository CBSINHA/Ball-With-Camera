using UnityEngine;

public class BallSpawnScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject ballPrefab;
    public Transform Position;
    public CameraFollowsBall follow;
    void Start()
    {
        GameObject ball= Instantiate(ballPrefab, Position.position, Quaternion.identity);
        follow.Ball = ball.transform;
    }
}
