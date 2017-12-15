using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour {

    public Transform ballPrefab;

	// Use this for initialization
	void Start () {
        Transform ball = Instantiate(ballPrefab) as Transform;
        Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), GetComponent<Collider2D>());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "BoxCollider")
        {
            Physics2D.IgnoreCollision(BoxCollider.collider,GetComponent<Collider>());
        }
    }
}
