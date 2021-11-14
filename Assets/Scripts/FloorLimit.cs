using UnityEngine;

public class FloorLimit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // SceneManager.LoadScene(0);
        FindObjectOfType<GameManager>().EndGame();
    }
}
