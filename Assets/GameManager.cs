using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Game Over

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUi;

    public void CompleteLevel()
    {
        completeLevelUi.SetActive(true);
    }
    
    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            // Restart scene
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        // Reload the active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
