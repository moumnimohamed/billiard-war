using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_plus_effect : MonoBehaviour {

	// Use this for initialization
		public ball_effect ball_effct;

	void Start () {
		ball_effct=GetComponent<ball_effect>();
	}
	
		void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag != "ground" && other.tag != "Player" && other.tag != "bullet")
		{
						ball_effct.play_effect(other.gameObject);
			do_attck (other.gameObject);
			Destroy(this.gameObject);

	    }
	} 

 public  void  do_attck (GameObject g)
 {
	   Destroy(g);
 }
 }
