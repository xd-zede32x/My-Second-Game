using UnityEngine;

public class Triger : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();
    }
}
