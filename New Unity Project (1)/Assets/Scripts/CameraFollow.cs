using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Camera Cam;
    public float dampTime = 0.5f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            Vector3 point = Cam.WorldToViewportPoint(new Vector3(target.position.x, target.position.y + 0.5f, target.position.z));
            Vector3 delta = new Vector3(target.position.x, target.position.y + 0.5f, target.position.z) - Cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f , point.z)); //(new Vector3(0.5, 0.5, point.z));
            Vector3 destination = transform.position + delta;


            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }
        
    }
}

/*
private float xMax;
private float yMax = 13f;
private float xMin;
private float yMin = 10f;

// public GameObject player;
//   private Vector3 offset = 10.0;

//public Transform target;
// Camera camera;

// void Start()
// {
//target = GameObject.Find("Player").transform;

//offset = transform.position - player.transform.position;
//  camera = GetComponent<Camera>();
// }

/*void LateUpdate()
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
        transform.position = Vector3.Lerp(transform.position, positon, smoothing * Time.deltaTime);
    }

}


}
*/
