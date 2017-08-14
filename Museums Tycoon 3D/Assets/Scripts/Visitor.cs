using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Visitor : MonoBehaviour {

	public NavMeshAgent navMeshAgent;
	public Museum museum;

	public float speed;

	Node Waypoint;

	// Use this for initialization
	void Start () {
		Waypoint = museum.ReturnRandomNode ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Waypoint != null) {
			navMeshAgent.SetDestination (Waypoint.transform.position);
		}
	}
}
