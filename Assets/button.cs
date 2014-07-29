using UnityEngine;
using System.Collections;

public class button : MonoBehaviour {

	// Use this for initialization
	public Transform fish;
	public float fallspeed;

	//change colour of button
	//make magic fish fall onto table
	void OnTriggerEnter () { 
		


	Destroy (gameObject);


	}
}
