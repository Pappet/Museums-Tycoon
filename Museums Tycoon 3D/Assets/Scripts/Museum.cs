using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Museum : MonoBehaviour {

	public int width;
	public int height;
	public GameObject RoomPrefab;

	Room[,] rooms;

	// Use this for initialization
	void Start () {
		rooms = new Room[width, height];
		for(int x = 0; x < width; x++){
			for(int z = 0; z < height; z++){
				Instantiate (RoomPrefab, new Vector3(x,0,z), Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
