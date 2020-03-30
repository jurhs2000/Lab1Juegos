using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    private float velocity = 3;
    private float amplitud = 1;
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = startPos + new Vector3(0, Mathf.Sin(Time.time * velocity) * amplitud, 0);
    }
}
