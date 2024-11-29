using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    public float jumpStrength;

    void Start()
    {
        myRigidbody2D.gravityScale = 4;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        myRigidbody2D.linearVelocity = Vector2.up * jumpStrength;
    }
}
