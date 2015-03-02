using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	public Vector2 velocity = new Vector2(0,-4);
	public float range = 4;
	// Use this for initialization
	void Start () {
		
		rigidbody2D.velocity = velocity;
		transform.position = new Vector3 ( Random.Range(-10F, 10F), 
		                                  10.07f, 
		                                  transform.position.z);
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
