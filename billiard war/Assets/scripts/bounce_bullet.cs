using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce_bullet : MonoBehaviour {

public  float force_bouncing ;

private Rigidbody2D rgb2d;	// Use this for initialization
	void Start () {
		rgb2d = GetComponent<Rigidbody2D>();

		rgb2d.AddForce(new Vector2(force_bouncing,force_bouncing));
	}
	
	
}
