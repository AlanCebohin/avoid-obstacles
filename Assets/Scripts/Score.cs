using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;
    
    void Update()
    {
        if (player.position.y > 0)
        {
            score.text = player.position.z.ToString("0");
        } else score.text = score.text;
    }
}
