using UnityEngine;
using System.Collections;
/// <summary>
/// Handles Player movements. Assigns controls to player.
/// </summary>

public class Controls : MonoBehaviour {
	public float speed = 0.5f;
	public Camera fpsCam;
	float yaw = 0.0f;
	float pitch = 0.0f;

	// Use this for initialization
	void Start () {
	
		fpsCam.transform.parent = transform;
	}
	
	// Update is called once per frame
	void Update () {

		//Forward
		if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(0, 0, speed * Time.deltaTime);
		}

		//Backward
		if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(0, 0, -speed * Time.deltaTime);
		}

		//Left
		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(-speed * Time.deltaTime, 0, 0);
		}

		//Right
		if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(speed * Time.deltaTime, 0, 0);
		}

		yaw+= Input.GetAxis("Mouse X") * speed;
		pitch -= Input.GetAxis("Mouse Y") * speed;

		transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);


	}


}
