using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void onTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }
}
