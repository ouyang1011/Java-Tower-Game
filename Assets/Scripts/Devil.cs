// This script tests if the character is engaged to the devil and when it is true, it will open the fighting window with the devil’s status and image
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Class about testing if a fight starts
public class Devil : MonoBehaviour {
	public static Devil thisDevil;
	private bool ifFight;
	public string devilName;

	private DevilsList list;
	private DevilStatus fightDevil;
	// Use this for initialization
	void Start () {
		list = new DevilsList();
		fightDevil = new DevilStatus();
		thisDevil = this;
		ifFight = false;
	}

	// Update function called every frame
	void Update(){
		// Open fighting windows when a fight start
		if (ifFight) {
			fightDevil = list.GetDevil(devilName);
			GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement> ().fightScreen.SetActive (true);
			GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement> ().SetMoveable (false);
			GameObject.FindGameObjectWithTag ("Fighting").GetComponent<Fighting> ().SetDevil (fightDevil.GetHealth(), fightDevil.GetAttack(), fightDevil.GetDefense(), fightDevil.GetExp(), fightDevil.GetAvatar());
			Player.stuffs.Add (this.gameObject.name);
			this.gameObject.SetActive (false);
		}
	}

	// Able to start a fight when character is engage to a devil
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Player")) {
			ifFight = true;
		}
	}

	// Disable to start a fight when character is not engage to a devil
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.CompareTag ("Player")) {
			ifFight = false;
		}
	}
		
}
