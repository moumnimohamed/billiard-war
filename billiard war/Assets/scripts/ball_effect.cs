using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_effect : MonoBehaviour {

public GameObject effect_explo;
	// Use this for initialization

	
	
	// Update is called once per frame
	void Update () {
		
		
	}
	public void play_effect (GameObject g)
	{
        GameObject eff=Instantiate(effect_explo,g.transform.position,Quaternion.identity) as GameObject;
                   Destroy(eff,0.4f);

                
	}
}
