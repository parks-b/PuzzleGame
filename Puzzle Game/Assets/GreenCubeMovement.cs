using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCubeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;

    private Vector3 targetPosition;

    private Rigidbody rb;

    void Start()
    {
        targetPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            targetPosition += Vector3.right * 19f;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            targetPosition -= Vector3.right * 19f;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            targetPosition += Vector3.up * 6f;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            targetPosition -= Vector3.up * 6f;
        }

        

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
     void OnCollisionEnter(Collision collision)
    {
        // Check if the collision was with an object tagged "wall"
        if (collision.gameObject.CompareTag("wall"))
        {
            // Stop the cube's movement
            speed = 0.0f;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}

