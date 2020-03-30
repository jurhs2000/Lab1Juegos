using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    private float velocity = 10;
    private Vector3 startPos;
    private float jumpHeight = 250f;
    private bool isFalling;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.localPosition;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.y < -13)
        {
            transform.localPosition = startPos;
            velocity = 10;
        }
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * velocity, 0,
                                        Input.GetAxis("Vertical") * velocity) * Time.deltaTime, Space.World);
        if (Input.GetKey(KeyCode.Space) && !isFalling)
        {
            rb.AddForce(Vector3.up * jumpHeight);
            isFalling = true;
        }

    }

    // Detect when collision with something (Ground)
    void OnCollisionEnter(Collision other)
    {
        isFalling = false;
    }
}
