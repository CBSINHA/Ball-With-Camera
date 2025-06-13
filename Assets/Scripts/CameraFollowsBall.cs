using UnityEngine;

public class CameraFollowsBall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Camera Follows Ball script has started.");
    }

    // Update is called once per frame
    public Vector3 distanceFromBall;
    public Transform Ball;
    void Update()
    {
        transform.position= Ball.position + distanceFromBall;
    }
}
