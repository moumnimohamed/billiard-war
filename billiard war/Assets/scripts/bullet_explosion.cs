using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_explosion : MonoBehaviour {

	// Use this for initialization
public shake_camera shake_cam;
public float shake_power;
public float shake_duration;


	public ball_effect ball_effct;
	public GameObject explosion;
	void Start () {
		shake_cam =GameObject.Find("Main Camera").GetComponent<shake_camera>();
		ball_effct=GetComponent<ball_effect>();
	}
	public 	void OnCollisionEnter2D(Collision2D other)
	{

	if (other.collider.tag != "ground" && other.collider.tag != "Player" && other.collider.tag != "bullet")
		{
			explosion.SetActive(true);
            ball_effct.play_effect(this.gameObject);
				       shake_cam.shacknow(shake_power,shake_duration);

				   Destroy(this.gameObject,0.05f);

	    }
	}
	

}
