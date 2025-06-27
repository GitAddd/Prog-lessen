using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 20f; // Snelheid van de speler

    void Update()
    {
        // Bereken de beweging over X en Z op basis van gebruiker input
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        // Maak een Vector3 van de beweging
        Vector3 move = new Vector3(moveX, 0f, moveZ);

        // Beweeg het object in wereldruimte
        transform.Translate(move, Space.World);
    }
}