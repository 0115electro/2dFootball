using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    private Collider ball;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ball = GetComponent<Collider>();
    }

    void Update()
    {
        
    }

}
