using UnityEngine;

public class CoinCollectAnimation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Coin Collect Animation Script Started");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Debug.Log("Coin collected!");
            ScoreManager.instance.AddScore(10);
            Invoke("RemoveCoin", 0.3f);
        }
    }
    void RemoveCoin()
    {
        Destroy(gameObject);
    }
}
