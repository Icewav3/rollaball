using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 rotationForce = new Vector3(0f,0f,0f);
    private void Update()
    {
        transform.Rotate(rotationForce * Time.deltaTime);
    }
}
