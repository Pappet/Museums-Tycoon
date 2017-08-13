using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour {

	public Museum museum;
	public GameObject Wall_North;
	public GameObject Wall_East;
	public GameObject Wall_South;
	public GameObject Wall_West;

	void Awake(){
		museum = FindObjectOfType<Museum> ();
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

	public void SetUpWalls(int x, int y){
		if(x == 0 || x < museum.width-1){
			Wall_West.SetActive (false);
		}
		if (y == 0 || y < museum.height-1) {
			Wall_South.SetActive (false);
		}
		if(x == museum.width || x > 0){
			Wall_East.SetActive (false);
		}
		if (y == museum.height || y > 0) {
			Wall_North.SetActive (false);
		}
	}
}
