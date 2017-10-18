using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion_effect : MonoBehaviour {

				void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag != "ground" && other.tag != "Player" && other.tag != "bullet")
		{
			do_attck (other.gameObject);
	    }
	} 

 public  void  do_attck (GameObject g)
 {
	   Destroy(g);
	   Destroy(this.gameObject);
 }
}
