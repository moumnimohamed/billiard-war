using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Floating_text2 : MonoBehaviour {

	
public Animator anim;
private Text Damagetext;

	void OnEnable() {
		AnimatorClipInfo[] clipInfo = anim.GetCurrentAnimatorClipInfo(0);
		Destroy(gameObject,clipInfo[0].clip.length);
		Damagetext=anim.GetComponent<Text>();
	}
	
	public void settext(string texto)
	{
        anim.GetComponent<Text>().text=texto;
	}
}
