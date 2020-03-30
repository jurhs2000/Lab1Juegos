using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float velocity = 5;
    private Vector3 startPos;
    private GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.localPosition;
        sphere = GameObject.Find("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        if (sphere.transform.localPosition.y < -13)
        {
            transform.localPosition = startPos;
        }
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * velocity, 0,
                                        Input.GetAxis("Vertical") * velocity) * Time.deltaTime, Space.World);
    }
}
