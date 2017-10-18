using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virus_bulet_child : MonoBehaviour {

ball_effect ball_effct;

void Start () {
// this for damage popup

ball_effct=GetComponent<ball_effect>();
	}
public float life = 0 ;
	// Use this for initialization
	
	


public 	void OnCollisionEnter2D(Collision2D other)
	{

	if (other.collider.tag != "ground" && other.collider.tag != "Player" && other.collider.tag != "bullet" && other.collider.tag != "score")
		{
			do_attck (other.gameObject);
			ball_effct.play_effect(other.gameObject);
	    }
	}

// this for bullet missile attack
		void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag != "ground" && other.tag != "Player" && other.tag != "bullet" && other.tag != "score")
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
