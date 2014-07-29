using UnityEngine;
using System.Collections;

public class text : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

	GetComponent <TextMesh> ().text =
		"Welcome, challenger,\n" +
		"the only way to get the magical fish inside \n" +
		"the Ducky Palace is to walk through the maze\n" +
		"But don't forget to collect some sparkles on your way,\n" +
		"the gate can only be opened with the power of sparkles!";

	
	}

}
