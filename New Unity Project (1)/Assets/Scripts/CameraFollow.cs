using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    
    private float xMax;
    private float yMax = 13f;
    private float xMin;
    private float yMin = 10f;

    public GameObject player;
    private Vector3 offset;

    //public Transform target;
    // Camera camera;

    void Start()
     {
    //target = GameObject.Find("Player").transform;

        offset = transform.position - player.transform.position;
    //  camera = GetComponent<Camera>();
     }

    void LateUpdate()
    {
        //transform.position = new Vector3(Mathf.Clamp(target.position.x, xMin, xMax), Mathf(target.position.y, yMin, yMax), transform.position.z);
        //transform.position = new Vector3(target.position.x, target.position.y + yMin, target.position.z);
        transform.position = player.transform.position + offset;
    }
    // void Update()
    //  {
    //   if(target)
    //   {
    //       transform.position = Vector3.Lerp(transform.position, target.position, 0.1f) + new Vector3(0,0,-10);
    //   }
    //  }
/*
    public Transform t = null;
    public float smoothing = 5f;
    Vector3 offset;
    // Use this for initialization
    public void SetOffset(Transform t)
    {
        this.t = t;
        offset = transform.position - t.position;
    }

    void FixedUpdate()
    {
        if (t != null)
        {
            Vector3 positon = t.position + offset;
            transform.position = Vector3.Lerp(transform.position, positon, smoothing);
        }

    }*/


}
