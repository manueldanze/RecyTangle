using UnityEngine;


public class PipeMove_Script : MonoBehaviour
{
    private float moveSpeed = 2;
    private float deadZone = -11;


    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }

    }
}
