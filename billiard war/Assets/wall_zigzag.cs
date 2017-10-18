using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_zigzag : MonoBehaviour {

public shake_camera shake_cam;
public GameObject	effect;

public float shake_power;
public float shake_duration;



void Start()
{
}

void OnCollisionEnter2D(Collision2D other)
{
	if(other.collider.tag=="bullet")
	{
        GameObject eff =Instantiate(effect,other.transform.position,Quaternion.identity);
		Destroy(eff,0.5f);
	       shake_cam.shacknow(shake_power,shake_duration);
	      
		   

	}
}
}
