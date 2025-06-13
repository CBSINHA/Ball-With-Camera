using JetBrains.Annotations;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("BallMovement script has started.");
        
    }

    // Update is called once per frame
    public float speed;

    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        float horizontal = Input.GetAxis("Horizontal"),vertical=Input.GetAxis("Vertical");
    Vector3 movement = new Vector3(horizontal, 0.00f, vertical) * Time.deltaTime * speed;
    rb.AddForce(movement,ForceMode.Impulse);


    }
}
