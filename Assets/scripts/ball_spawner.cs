using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class ball_spawner : MonoBehaviour {

public  GameObject [] balls_prefeb;

List<Transform> ls_pos =new List<Transform> ();
 
	// Use this for initialization
	void Start () {
		generate_ball();
	}
	
	 public void		generate_ball()
		{
               for(int i=0 ;i< this.transform.childCount;i++)
			   {
                   ls_pos.Add(this.transform.GetChild(i));
			   }


			for(int i=0;i<balls_prefeb.Length;i++){
				
				int pos_in_ls = Random.Range(0,ls_pos.Count);
            Transform spown_pos = ls_pos[pos_in_ls];
			ls_pos.RemoveAt(pos_in_ls);
		GameObject	test =balls_prefeb[Random.Range(0,balls_prefeb.Length)]  ;
        GameObject temp= Instantiate(test,spown_pos.position,Quaternion.identity) as GameObject;
            temp.transform.SetParent(this.transform);
	}
}
}
