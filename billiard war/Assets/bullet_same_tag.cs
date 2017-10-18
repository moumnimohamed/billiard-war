using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_same_tag : MonoBehaviour {



      public ball_effect ball_eff;

	 /// <summary>
	 /// Start is called on the frame when a script is enabled just before
	 /// any of the Update methods is called the first time.
	 /// </summary>
	 void Start()
	 {
		 ball_eff = GetComponent<ball_effect>();
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
		 ball_eff.play_effect(bal);
		 Destroy(bal);
	 }

	          Destroy(this.gameObject);
	 
 }
}
