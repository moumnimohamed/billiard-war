using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class shake_camera : MonoBehaviour {

    public float shaketimer;
   public float shakeamount;


	// Use this for initialization
  void Start() {


  }
	
	// Update is called once per frame
	void Update () {

        

       
            if (shaketimer >= 0)
            {
                Vector2 shakepos = Random.insideUnitCircle * shakeamount;
                transform.position = new Vector3(transform.position.x + shakepos.x, shakepos.y, transform.position.z);
                shaketimer -= Time.deltaTime;
            }
        }
	

    public  void shacknow(float shakepwr, float shakedur)
    {
       
            shakeamount = shakepwr;
            shaketimer = shakedur;
        
    }
}
