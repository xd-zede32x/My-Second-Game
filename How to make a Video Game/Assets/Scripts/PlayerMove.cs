using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardSpeed = 200;
    public float sideforwardSpeed = 200;

    private void FixedUpdate()
    {
        GetInput();
    }
    public void GetInput()
    {
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sideforwardSpeed * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sideforwardSpeed * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (rb.position.y <= -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}