using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visitor : MonoBehaviour {

	Museum museum;
	Transform Waypoint;

	public float speed;


	void Awake(){
		museum = FindObjectOfType<Museum> ();
	}

	// Use this for initialization
	void Start () {
		Waypoint = museum.ReturnRandomRoom ().transform;
	}
	
	// Update is called once per frame
	void Update () {
		ReachedWaypoint ();

	}

	void MoveTowardsWaypoint(){
		Vector3 pos = transform.position;
		float step = speed * Time.deltaTime;

		pos =  Vector3.Lerp(transform.position,Waypoint.position,step);
		pos.y = 0.15f;

		transform.position = pos;
	}

	void ReachedWaypoint(){
		if (Vector3.Distance (transform.position, Waypoint.position) > 0.5f) {
			MoveTowardsWaypoint ();
		} else {
			Waypoint = museum.ReturnRandomRoom ().transform;
		}
	}
}
