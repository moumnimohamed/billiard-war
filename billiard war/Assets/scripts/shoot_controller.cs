using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_controller : MonoBehaviour {


public float aimWidth; 
 public float aimHeight; 
  public Texture2D Aim; 
  public static bool ShowCursor; 
 public CursorMode cursorMode = CursorMode.ForceSoftware;
	// Use this for initialization
	void Start () { 		
		Time.timeScale = 1; 
		 ShowCursorInLoad();
	}
	
	// Update is called once per frame
	void Update () {
		ShowCursorInLoad(); 
		 if(ShowCursor){
			 Cursor.SetCursor (Aim,new Vector2(aimWidth, aimHeight),cursorMode); 
			  }else
			  { Cursor.SetCursor (null, Vector2.zero, cursorMode); 
			  } 
			 }
			   void ShowCursorInLoad() 
			    {  if(Time.timeScale == 1) 
				 ShowCursor = true; 
			  if(Time.timeScale == 0) 
			  ShowCursor = false;
	}
}
