using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 10;
    void Start()
    {

    }


    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
