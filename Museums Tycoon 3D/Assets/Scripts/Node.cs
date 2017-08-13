using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {

	public GameObject ItemPrefab;
	GameObject placedItem;

	public bool hasItem = false;

	// Use this for initialization
	void Start () {
		if(hasItem){
			SetItem ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SetItem(){
		placedItem = Instantiate (ItemPrefab,transform.position, Quaternion.identity);
		placedItem.transform.SetParent (transform);
	}

	void RemoveItem(){
		Destroy (placedItem);
		hasItem = false;
	}
}
