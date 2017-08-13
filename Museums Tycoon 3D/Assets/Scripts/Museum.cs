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
			for(int y = 0; y < height; y++){
				GameObject go = Instantiate (RoomPrefab, new Vector3(x,0,y), Quaternion.identity);
				go.name = "Room x:" + x + "/ y:" + y;
				go.transform.SetParent(this.transform);
				rooms [x, y] = go.GetComponent<Room> ();
				rooms [x, y].SetUpWalls (x,y);

			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
