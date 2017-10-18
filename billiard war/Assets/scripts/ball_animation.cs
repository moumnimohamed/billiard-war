using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_animation : MonoBehaviour {

  Animator anim;
	// Use this for initialization
	void Start () {
		anim=GetComponent<Animator>();
			anim.SetInteger("state",0);
		}
	

	void Update () {
		//anim.SetInteger("state",1);
		
	
}
}
