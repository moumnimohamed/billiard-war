using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class load_sene : MonoBehaviour {

	// Use this for initialization
	public int csene_nbr;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}
	public void load_scene (){
		SceneManager.LoadScene(csene_nbr);
	}
}
