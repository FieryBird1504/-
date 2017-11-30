﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ball : NetworkBehaviour 
{

    public float maxSpeed = 10f;
    Rigidbody2D rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if(!isLocalPlayer)
        {
            return;
        }
        else
        {
            float move = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);

            float up = Input.GetAxis("Vertical");
            rb.velocity = new Vector2(rb.velocity.x, up * maxSpeed);
        }
	}
}
