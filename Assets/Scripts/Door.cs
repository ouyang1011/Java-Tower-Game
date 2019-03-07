// This script tests if the character is trying to open a door, and if it is true, it will open the door window
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Class to test if a door is opening
public class Door : MonoBehaviour {
	private GameObject doorTran;
	private bool ifnextDoor;
	private bool ifDoorOpen;

	// Use this for initialization
	void Start () {
		doorTran = this.gameObject;
		ifnextDoor = false;
		ifDoorOpen = false;
	}
	
	// Update is called every frame
	void Update () {
		// Open door questions window and disable the door
		if (ifnextDoor == true && Input.GetAxis ("Open") != 0 && ifDoorOpen == false) {
			ifDoorOpen = true;
			Player.stuffs.Add (doorTran.name);
			GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement> ().doorScreen.SetActive (true);
			GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement> ().SetMoveable (false);
			doorTran.SetActive (false);
		}
	}

	// Able to open a door when character is next to the door
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Player")) {
			ifnextDoor = true;
		}
	}

	// Able to open a door when character is not next to door
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.CompareTag ("Player")) {
			ifnextDoor = false;
		}
	}
}
