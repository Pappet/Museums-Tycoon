using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Museum : MonoBehaviour {

	public List<Node> Nodes = new List<Node>();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public Node ReturnRandomNode(){
		return Nodes [Random.Range (0, Nodes.Count)];
	}
}
