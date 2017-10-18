using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bllet_same_tag : MonoBehaviour {

ball_effect ball_effct;
   void Start () {
		ball_effct=GetComponent<ball_effect>();
	}
   
	public 	void OnCollisionEnter2D(Collision2D other)
	{

	if (other.collider.tag != "ground" && other.collider.tag != "Player" && other.collider.tag != "bullet")
		{
			do_attck (other.gameObject);
	    }
	}


//public  List<GameObject> ls_balls = new List<GameObject>();
public GameObject [] balls;
 public string temp_tag;
 public  void  do_attck (GameObject g)
 {
	 temp_tag = g.tag;
	 balls = GameObject.FindGameObjectsWithTag(temp_tag);
	 foreach(GameObject bal in balls)
	 {
		 Destroy(bal);
			ball_effct.play_effect(bal);
		 
	 }
	 Destroy(this.gameObject);
 }


}
