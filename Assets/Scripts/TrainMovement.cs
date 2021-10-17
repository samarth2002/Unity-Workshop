using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    Rigidbody rb;

    public float trainSpeed = 600f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0f, 0f , trainSpeed*Time.deltaTime,ForceMode.VelocityChange);
    }
}
