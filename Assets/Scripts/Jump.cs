﻿using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public Vector2 jumpForce = new Vector2 (0,300);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		/*if (Input.GetMouseButtonDown (0)) {
			//print ("Hey");
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce (jumpForce);
		
		}*/
		if (Input.GetKey(KeyCode.RightArrow)) {
			this.transform.position += new Vector3(0.07f,0f,0f);
			
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			this.transform.position -= new Vector3(0.07f,0f,0f);
			
		}
	
	}
}
