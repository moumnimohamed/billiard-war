using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_missile : MonoBehaviour {

	// Use this for initialization	
	public ball_effect ball_effct;

void Start () {
		ball_effct=GetComponent<ball_effect>();
	}
			void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag != "ground" && other.tag != "Player" && other.tag != "bullet")
		{
			do_attck (other.gameObject);
			            ball_effct.play_effect(other.gameObject);

	    }
	} 

 public  void  do_attck (GameObject g)
 {
	   Destroy(g);
 }
}
