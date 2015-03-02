using UnityEngine;
using System.Collections;

public class generate : MonoBehaviour {

	public GameObject rocks;
	private int score = 0;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("CreateObstacle", 2f, 0.5f);

	
	}
	
	// Update is called once per frame
	void Update () {
		//print (score);
	}
	void CreateObstacle(){

		Instantiate (rocks);
		score++;
		print (score);
	}
}
