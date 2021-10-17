using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Vector3 Offset = new Vector3(2,2,2);
    public Transform target;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = target.position + Offset;
    }
}
