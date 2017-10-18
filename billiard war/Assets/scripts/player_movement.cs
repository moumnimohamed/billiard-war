using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour {

AudioSource audi;
public AudioClip  walk;
public score_bullet_manager  score_bull_manager;
  Rigidbody2D body2d;
  Animator anim;
  public float maxSpeed;
	// Use this for initialization
	void Start () {
		anim=GetComponent<Animator>();
		audi=GetComponent<AudioSource>();
		
		body2d=GetComponent<Rigidbody2D>();
		
	}
	public void walk_func(){
		 audi.PlayOneShot(walk)	;
		 }
	// Update is called once per frame
	void Update () {
		float hor = Input.GetAxis ("Vertical");
		body2d.velocity = new Vector2 (body2d.velocity.x,  hor * maxSpeed);
		if(body2d.velocity.y!=0){
		anim.SetInteger("state",1);
		}else
		{
		anim.SetInteger("state",0);
		}
          
		if(transform.position.y >81f)
		{
transform.position =new Vector3(transform.position.x,81f,transform.position.z);
 
		}else if(transform.position.y <-73f)
		{
transform.position =new Vector3(transform.position.x,-73f,transform.position.z);
 
		}
	}


// add score to score_bullet_manager
	void OnTriggerEnter2D(Collider2D other)
{
	if(other.tag=="score")
	{
		Destroy(other.gameObject);
		score_bull_manager.score +=1;

	}
	if(other.tag=="jaune"|| other.tag=="vert" || other.tag=="orange" || other.tag=="mauve" || other.tag=="rouge"|| other.tag=="bleu"|| other.tag=="maron"|| other.tag=="noire"|| other.tag=="vert" )
	{
		panell_gameover.SetActive(true);
	}
}

public  GameObject panell_gameover; 

}
