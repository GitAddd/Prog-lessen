using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score; // The score variable, adjustable in the Unity Inspector

    // Method to add points to the score
    public void AddScore(int points)
    {
        score += points; // Add the given points to the score
        Debug.Log("Score bijgewerkt: " + score); // Debug the updated score to the console
    }
}