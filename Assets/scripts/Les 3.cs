using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float speed = 5f;
    public float timeLeft = 20f;
    private int score = 0;
    public GameObject coinPrefab; // Reference to the coin prefab in Inspector

    void Update()
    {
        // Movement
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ).normalized * speed * Time.deltaTime;
        transform.Translate(move);

        // Timer
        if (timeLeft <= 0)
        {
            Debug.Log("Game Over! Eindscore: " + score);
            enabled = false;
            return;
        }

        timeLeft -= Time.deltaTime;
        Debug.Log("Tijd: " + Mathf.Round(timeLeft) + " | Score: " + score);
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has the CoinTag component
        if (other.CompareTag("Coin"))
        {
            score += 10;
            Debug.Log("Munt gepakt! +10 punten");
            Destroy(other.gameObject);
        }
    }
}