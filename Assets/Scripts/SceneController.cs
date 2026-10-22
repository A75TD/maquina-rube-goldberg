using UnityEngine;
using UnityEngine.SceneManagement;

// R = reiniciar la escena.
public class SceneController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
