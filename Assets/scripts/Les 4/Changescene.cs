using UnityEngine;
using UnityEngine.SceneManagement;

public class Changescene : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("opdracht 4");
        
    }
}
