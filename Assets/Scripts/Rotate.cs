using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //public bool random;
    public Vector3 rotationForce = new Vector3(0f,0f,0f);

    /*private void Start()
    {
        if (random)
        {
            Random rng = new UnityEngine.Random();
        }
    }*/

    private void Update()
    {
        /*if (random)
        {
            transform.Rotate(rotationForce * Time.deltaTime);
        }
        else
        {*/
            transform.Rotate(rotationForce * Time.deltaTime);
        //}
    }
}
