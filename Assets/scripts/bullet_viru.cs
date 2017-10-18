using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_viru : MonoBehaviour {

	public float nember_of_virus = 0 ;
	public float shoot_force = 1000 ;
	
	public GameObject virus;
	// Use this for initialization
	


void Start () {
	}
public 	void OnCollisionEnter2D(Collision2D other)
	{

	if (other.collider.tag != "ground" && other.collider.tag != "Player" && other.collider.tag != "bullet")
		{
			do_attck (other.gameObject);

	    }
	}

// this for bullet missile attack


 public  void  do_attck (GameObject g)
 {
	 for(int i=0 ;i<nember_of_virus;i++){
	 GameObject vir= Instantiate(virus,transform.position,Quaternion.identity);

	         Vector2 force = new Vector2(Random.Range(-shoot_force,shoot_force),Random.Range(-shoot_force,shoot_force));

	 				vir.GetComponent<Rigidbody2D>().AddForce(  force);	  
 }
  Destroy(this.gameObject);
 }
}
