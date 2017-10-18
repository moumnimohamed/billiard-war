using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score_bullet_manager : MonoBehaviour {

public GameObject shoot_pos;
public GameObject shoot_line;
public Animator stick_anim;


public GameObject [] ls_ballInHierarchy ;
public string[] balls_tags ;
public float shoot_force;
     public GameObject parent_bullet;
     public GameObject plus_bullet;
     public GameObject same_tag_bullet;
     public GameObject virus_bullet;
     public GameObject missile_bullet;
     public GameObject explo_bullet;
	  public int q_parent_bullet;
     public int q_plus_bullet;
     public int  q_same_tag_bullet;
     public int q_virus_bullet;
     public int q_missile_bullet;
     public int q_explo_bullet;
   public List<GameObject> ls_temp_ball =new List <GameObject> ();

   public Text score_text;
   public int score;

   public	GameObject first_ball = null ;

	// Use this for initialization
    generate_row generateNew;

	void Start () {
        
        stick_anim=GetComponent<Animator>();
			generateNew =GetComponent<generate_row>();

	}
	    //test if thire is no enmy in hierarchy
       GameObject balltest=null ;
	// Update is called once per frame
	void Update () {
    if( Input.GetMouseButtonDown(1) &&  first_ball ==null ){
       stick_anim.SetInteger("state",1);
             }else
             {
       stick_anim.SetInteger("state",0);

             }
		score_text.text=score.ToString();
        
	
hierarchy_balls();
  }
  	private void shoot_now(){
          
      


          if(first_ball ==null){
              
      if(ls_temp_ball.Count>0){
 

	 first_ball =	Instantiate(ls_temp_ball[0] ,shoot_pos.transform.position,Quaternion.identity) as GameObject;
				first_ball.GetComponent<Rigidbody2D>().AddForce(  shoot_line.transform.right *shoot_force);
        ls_temp_ball.Remove(ls_temp_ball[0]);
}
else{
  	 first_ball =	Instantiate(parent_bullet ,shoot_pos.transform.position,Quaternion.identity) as GameObject;
                
				first_ball.GetComponent<Rigidbody2D>().AddForce(  shoot_line.transform.right *shoot_force);
}
StartCoroutine("generate_rows");

          }
      }
public void button_plus_bullet(){

        if(score>q_plus_bullet)
  {
      score-=q_plus_bullet;
      ls_temp_ball.Add(plus_bullet);  
  }

     }
     public void button_same_tag_bullet()
     {
               if(score>q_same_tag_bullet)
  {
      score-=q_same_tag_bullet;
      ls_temp_ball.Add(same_tag_bullet);  
  }
     }
     public void button_virus_bullet()
     {
          if(score>q_virus_bullet)
  {
      score-=q_virus_bullet;
      ls_temp_ball.Add(virus_bullet);  
  }
     }
     public void button_missile_bullet()
     {
               if(score>q_missile_bullet)
  {
      score-=q_missile_bullet;
      ls_temp_ball.Add(missile_bullet);  
  } 
     }
     public void button_explo_bullet()
     {
             if(score>q_explo_bullet)
  {
      score-=q_explo_bullet;
      ls_temp_ball.Add(explo_bullet);  
  } 
     }



	IEnumerator  generate_rows ()
	{
          yield return new WaitForSeconds(5f);
           //search in hierarchy if there is a type of enmy
           hierarchy_balls();

//if there is no enmy
for(int i=0 ;i< ls_ballInHierarchy.Length;i++){
if(ls_ballInHierarchy[i] != null){
    balltest= ls_ballInHierarchy[i] ;
    break;
}
}
       
if(balltest!=null){
generateNew.generateNewRow();
}else
{
   Debug.Log("you win");
}
		 

	}

private	void hierarchy_balls()
    {
 for(int i=0 ;i<balls_tags.Length;i++){
            ls_ballInHierarchy[i] = null ;  
    }

        for(int i=0 ;i<balls_tags.Length;i++){
            ls_ballInHierarchy[i] = GameObject.FindGameObjectWithTag(balls_tags[i]) ;  
    }

    }

}
