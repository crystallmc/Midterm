using UnityEngine;
using System.Collections;

public class Capsule: MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public float turnSpeed = 50f;
	public float moveSpeed =50f;
	public float jumpForce =50f;

	// Update is called once per frame
	void Update () {

	//First make the camera points towards the mouse all the time

	transform.Rotate (0f, Input.GetAxis ("Mouse X") * turnSpeed * Time.deltaTime, 0f);
	//transform.Rotate (Input.GetAxis ("Mouse Y") * turnSpeed * Time.deltaTime, 0f, 0f);
	//transform.Rotate (Input.GetAxis ("Mouse Y") * turnSpeed * Time.deltaTime, 0f, 0f);
	//==================================Ask about position of XYZ roatate variables==================================
	

	// Now make the controller to translate (move)
	transform.Translate (Vector3.right* Input.GetAxis ("Horizontal")* Time.deltaTime* moveSpeed);
	transform.Translate (Vector3.forward* Input.GetAxis ("Vertical")* Time.deltaTime* moveSpeed);




	}


	//make the insturction board show word






}
