using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    //public float camera_angle;
    private Vector3 offset;
    //private Vector3 rotational_offset;
    void Start()
    {
        offset = transform.position - player.transform.position;
        //rotational_offset = ;
    }
    
    void LateUpdate() //very important for things that need to get prior state of something
    {
        transform.position = player.transform.position + offset;
        //transform.rotation = PlayerController.GetVector();
    }
}
