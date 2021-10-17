using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float hSpeed = 50f;
    public float fwdSpeed = 50f;
    public float jumpForce = 50f;
    bool OnGround;
    Rigidbody rb;
    int jumpsLeft = 0;
    int MaxJumps;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();   
        MaxJumps =1;
    }

    // Update is called once per frame
    void Update()
    {
        float hMove = Input.GetAxis("Horizontal")*Time.deltaTime*hSpeed;
        rb.AddForce(hMove, 0f , fwdSpeed*Time.deltaTime);
        if(Input.GetButtonDown("Jump")&&jumpsLeft>0)
        {
            Jump();
            jumpsLeft--;
        }
    }

    void Jump()
    {
        rb.AddForce(0f , jumpForce , 0f);
    }
    void OnCollisionEnter(Collision other)
    {
        jumpsLeft = MaxJumps;
        if (other.gameObject.tag == "ground")
        {
            OnGround = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "ground")
        {
            OnGround = false;
        }
    }
}
