using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody rb; // Reference to Rigidbody
    public float moveSpeed = 5f; // Movement speed
    public float jumpForce = 5f; // Jump force

    void Start()
    {
        // Get Rigidbody component
        rb = GetComponent<Rigidbody>();
        Debug.Log("Player ready!");
    }

    void Update()
    {
        // Move left/right with moveSpeed
        float input = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * input * moveSpeed * Time.deltaTime;

        // Jump with spacebar using AddForce
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}