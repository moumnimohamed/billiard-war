using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_movetoward : MonoBehaviour {


public GameObject P_player;
public float speed;
      
	// Use this for initialization
	void Start () {
        StartCoroutine("move_star");
	}
	
	// Update is called once per frame
	void Update () {
		if
		(P_player!=null)
	transform.position =	 Vector2.MoveTowards(transform.position,P_player.transform.position,speed*Time.deltaTime);
		
	}


	IEnumerator move_star ()
	{
        yield return  new WaitForSeconds(0.5f);
		P_player =  GameObject.FindGameObjectWithTag("Player");
		speed= Random.Range(speed,speed+50);
	}
}
