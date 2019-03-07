// This script tests if the character is engaged to a crystal and check which kind of crystals it is
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This class includes all the functions about crystal
public class Crystal : MonoBehaviour {
	private bool isUsed;
	public string type;

	// Use this for initialization
	void Start(){
		isUsed = false;
	}

	// Update function called every frame
	void Update(){
		if (isUsed) {
			this.gameObject.SetActive (false);
			isUsed = false;
			AddStatus ();
			Player.stuffs.Add (this.gameObject.name);
		}
	}

	// Function test if the chararcter is in particular area
	void OnTriggerEnter2D(Collider2D other){
		isUsed = true;
		GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement> ().SetMoveable (false);
	}

	// Change character's attack, defense, max helath after using crystals
	void AddStatus(){
		switch (type) {
		// crystals to increase attack power	
		case "Attack":
			Player.attack += 5;
			GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement> ().ChangeFeedback ("Your got 5 Attack Power.");
			break;
		// crystals to increase defense power	
		case "Defense":
			Player.defense += 3;
			GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement> ().ChangeFeedback ("Your got 3 Defense Power.");
			break;
		// crystals to increase max healths
		case "Health":
			Player.maxH += 50;
			GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement> ().ChangeFeedback ("Your got 50 Max Health.");
			break;
		}
	}
}
