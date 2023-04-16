using UnityEngine;

public class PlayerColichion : MonoBehaviour
{
    public PlayerMove move;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
