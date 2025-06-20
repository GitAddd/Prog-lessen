using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f; // Adjustable speed in the Inspector
    public ScoreManager scoreManager; // Reference to the ScoreManager script

    void Start()
    {
        // Check if the ScoreManager reference is set
        if (scoreManager == null)
        {
            Debug.LogError("ScoreManager niet ingesteld!"); // Error if not set
        }
    }

    void Update()
    {
        // Move the player left/right using arrow keys or A/D
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Vector3 move = new Vector3(moveX, 0f, 0f);
        transform.Translate(move);
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collided object is a coin
        if (other.name == "Coin")
        {
            scoreManager.AddScore(10); // Add 10 points to the score
            Debug.Log("Munt gepakt!"); // Log that a coin was collected

            Destroy(other.gameObject);
        }
    }
}