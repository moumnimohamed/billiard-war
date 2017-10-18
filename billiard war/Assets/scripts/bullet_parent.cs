using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_parent : MonoBehaviour {

 
ball_effect ball_effct;

void Start () {
// this for damage popup
text_controller.Initialize();

ball_effct=GetComponent<ball_effect>();
	}
public string the_tag;
public float life = 0 ;
	// Use this for initialization
	
	


public 	void OnCollisionEnter2D(Collision2D other)
	{

	if (other.collider.tag != "ground" && other.collider.tag != "Player" && other.collider.tag != "bullet" && other.collider.tag != "score")
		{
			do_attck (other.gameObject);
			ball_effct.play_effect(other.gameObject);
			
	int nbr = Random.Range(0,6);
	   	
text_controller.cteatefloatingtext("+"+ Gave_etoile(other.gameObject,nbr).ToString(),other.gameObject.transform);
	    }
	}

// this for bullet missile attack
		void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag != "ground" && other.tag != "Player" && other.tag != "bullet" && other.tag != "score")
		{
			do_attck (other.gameObject);
			ball_effct.play_effect(other.gameObject);
		
			
	    }
	} 

 public  void  do_attck (GameObject g)
 {
	   Destroy(g);
	  
	   
 }


public GameObject [] etoile ;
public float speed;

private int Gave_etoile(GameObject g,int nbr)
{
	int nbr2 = nbr/2;
	for(int i =0;i<nbr2;i++){
	GameObject test = etoile[Random.Range(0,etoile.Length)] ;
 GameObject njma =   Instantiate (test,g.transform.position,Quaternion.identity) as GameObject;
Vector2 force = new Vector2(Random.Range(-speed,speed),Random.Range(-speed,speed));
 njma.GetComponent<Rigidbody2D>().AddForce(force);
// this is for our popup 
}
    return 2;


}




 }
