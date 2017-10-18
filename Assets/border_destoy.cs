using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class border_destoy : MonoBehaviour {



	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.collider.tag=="bullet")
		{
Destroy(other.gameObject);
		}
	}



}
