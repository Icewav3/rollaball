using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    
    void LateUpdate() //very important for things that need to get prior state of something
    {
        transform.position = player.transform.position + offset;
    }
}
