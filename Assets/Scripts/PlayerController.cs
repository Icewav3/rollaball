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
    public TextMeshProUGUI CurrentStage;
    public GameObject stage2;
    
    private Rigidbody rb;
    private float movementx;
    private float movementy;
    private int count;
    private int prefabcount;
    private int stagenum;
    
    /*private Vector3 movement;

    public Vector3 GetVector()
    {
        return movement;
    }
    */
    
    void Start()
    {
        GameObject[] getCount = GameObject.FindGameObjectsWithTag("Pickup");
        prefabcount = getCount.Length;
        rb = GetComponent<Rigidbody>();
        count = 0;
        stagenum = 1;
        setCountText();
        stage2.SetActive(false);
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
        if (count >= prefabcount)
        {
            stagenum++;
            CurrentStage.text = "Stage: " + stagenum.ToString();
            stage2.SetActive(true);
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
