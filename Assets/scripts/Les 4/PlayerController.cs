using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;             // Adjustable in Inspector
    public GameObject coinPrefab;        // Drag prefab here in Inspector

    void Start()
    {
        float randVal = Random.Range(-10, 10);
        Instantiate(coinPrefab, new Vector3(randVal, 0, 0), Quaternion.identity); // Spawns the coinPrefab at a random X position
    }

    void Update()
    {
        // Movement with left/right arrow keys or A/D keys
        float input = Input.GetAxis("Horizontal");
        // Multiply direction by speed and horizontal input value
        transform.Translate(Vector3.right * input * speed * Time.deltaTime);
    }
}