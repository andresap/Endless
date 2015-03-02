using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {


		void OnCollisionEnter2D (Collision2D col)
		{
			if(col.gameObject.tag == "Obstacles")
			{
				Destroy(col.gameObject);
			print ("Destroy");
			}
		}

}
