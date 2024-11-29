using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 10;
    public float deadZone = -36;
    void Start()
    {

    }


    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
