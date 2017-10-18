using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class load_scene : MonoBehaviour {



public string scene_name;
	// Use this for initialization
	public void load__scene()
    {
        
        
        SceneManager.LoadScene(scene_name);
        
    }
}
