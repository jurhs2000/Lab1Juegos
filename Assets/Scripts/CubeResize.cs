using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeResize : MonoBehaviour
{
    private float velocity = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z) && transform.localScale.x < 6)
            transform.localScale += Vector3.one * velocity * Time.deltaTime;
        if (Input.GetKey(KeyCode.X) && transform.localScale.x > -6)
            transform.localScale -= Vector3.one * velocity * Time.deltaTime;
    }
}
