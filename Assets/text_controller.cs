using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_controller : MonoBehaviour {


// this script manage the popup(prefebs)
//this an other script called text manager in hierarchy who manage the instanciation of popup
	public static floating_text popuptext;
	public static Floating_text2 popuptext2;
	
public static GameObject canvas;
	
	public static void Initialize(){

		canvas=GameObject.Find("Canvas");
		if(!popuptext){
		popuptext=Resources.Load<floating_text>("prefebs/Text_popup");
		}
		if(!popuptext2){
		popuptext2=Resources.Load<Floating_text2>("prefebs/Text_popup2");
		}
	}
	
	public static void cteatefloatingtext(string text,Transform location)
	{
		
        floating_text instance= Instantiate(popuptext);
		Vector2 screenposition=Camera.main.WorldToScreenPoint(location.position);
		instance.transform.SetParent(canvas.transform,false);
		instance.transform.position=screenposition;
		instance.settext(text);
	
	}
	public static void cteatefloatingtext2(string text,Transform location)
	{
		
        Floating_text2 instance= Instantiate(popuptext2);
		Vector2 screenposition=Camera.main.WorldToScreenPoint(location.position);
		instance.transform.SetParent(canvas.transform,false);
		instance.transform.position=screenposition;
		instance.settext(text);
	
	}
}
