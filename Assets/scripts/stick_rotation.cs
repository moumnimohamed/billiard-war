using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stick_rotation : MonoBehaviour {



    Rigidbody2D  rb2d;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	   this.transform.position = this.transform.parent.transform.position;
		
	}
	public float angle ;
	void FixedUpdate()
	{ 
		 CannonRotation(); 
	}
	public void CannonRotation()
	{Vector2 mousePos = Input.mousePosition; 
	 mousePos = Camera.main.ScreenToWorldPoint(mousePos); 
	  float deltaX = transform.position.x - mousePos.x; 
	   float deltaY = transform.position.y - mousePos.y; 
	    angle = Mathf.Atan2(deltaX,-deltaY) * Mathf.Rad2Deg;
	   rb2d.MoveRotation(angle+90f);


	}
}
