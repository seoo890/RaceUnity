using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector2 temp;

    public GameObject prayer;
    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - prayer.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = prayer.transform.position + offset;
        //Debug.Log(temp);
    }
}
