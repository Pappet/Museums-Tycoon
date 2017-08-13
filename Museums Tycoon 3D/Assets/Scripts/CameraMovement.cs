using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public float panSpeed = 20F;
	public Vector2 panLimit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;

		if (Input.GetKey ("w")) {
			pos.z += panSpeed * Time.deltaTime;
		}
		if (Input.GetKey ("a")) {
			pos.x -= panSpeed * Time.deltaTime;
		}
		if (Input.GetKey ("s")) {
			pos.z -= panSpeed * Time.deltaTime;
		}
		if (Input.GetKey ("d")) {
			pos.x += panSpeed * Time.deltaTime;
		}

		pos.x = Mathf.Clamp (pos.x, -panLimit.x, panLimit.x);
		pos.z = Mathf.Clamp (pos.z, -panLimit.y, panLimit.y);

		transform.position = pos;
	}
}
