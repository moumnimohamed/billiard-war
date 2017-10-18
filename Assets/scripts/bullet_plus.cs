using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_plus : MonoBehaviour {



public GameObject bullect_effect;

	public 	void OnCollisionEnter2D(Collision2D other)
	{

	if (other.collider.tag != "ground" && other.collider.tag != "Player" && other.collider.tag != "bullet")
		{
			do_attck (other.gameObject);
	    }
	}
public  void  do_attck (GameObject g)
 {
	GameObject eff=   Instantiate(bullect_effect,g.transform.position,Quaternion.identity) as GameObject;
	   Destroy(this.gameObject);

 }
}
