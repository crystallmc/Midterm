using UnityEngine;
using System.Collections;

public class sparkle : MonoBehaviour {

	public Transform door; 

	void OnTriggerEnter () { 
		
	
	Destroy (door.gameObject);
		
		

	Destroy (gameObject);
	}




}