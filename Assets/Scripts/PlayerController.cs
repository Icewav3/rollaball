using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI Score;
    public GameObject WinTextGameObject;
    
    private Rigidbody rb;
    private float movementx;
    private float movementy;
    private int count;
    /*private Vector3 movement;

    public Vector3 GetVector()
    {
        return movement;
    }
    */
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        WinTextGameObject.SetActive(false);
        setCountText();
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>(); //movement value returns vector2 var type?
        movementx = movementVector.x;
        movementy = movementVector.y;
    }

    private void setCountText()
    {
        Score.text = "Current Score: " + count.ToString();
        if (count >= 12)
        {
            WinTextGameObject.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementx, 0.0f, movementy);
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            count++;
            other.gameObject.SetActive(false);
            setCountText();
        }
    }
}
