using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate_row : MonoBehaviour {



public Transform continner;
public GameObject row_prefb;

public float currentSpawn;

public Vector2 desired_pos;
public float distance_between_ball;

private Vector2 continer_star_pos;
	// Use this for initialization
	void Start () {
		generateNewRow();
		generateNewRow();
		continer_star_pos=continner.transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
	

		if((Vector2) continner.position!=desired_pos)
		continner.transform.position=Vector3.MoveTowards(continner.transform.position,desired_pos,Time.deltaTime*30);
	}
	public void generateNewRow ()
    {
        GameObject go = Instantiate(row_prefb) as GameObject;
        go.transform.SetParent(continner);
        go.transform.localPosition = Vector2.left * currentSpawn;
        currentSpawn -= distance_between_ball;
        desired_pos = continer_star_pos +(Vector2.right * currentSpawn);

}}
