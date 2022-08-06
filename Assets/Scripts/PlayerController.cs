using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    private Rigidbody rb;
    private float movementx;
    private float movementy;
    
    /*private Vector3 movement;

    public Vector3 GetVector()
    {
        return movement;
    }
    */
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>(); //movement value returns vector2 var type?
        movementx = movementVector.x;
        movementy = movementVector.y;
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementx, 0.0f, movementy);
        rb.AddForce(movement * speed);
    }
}
