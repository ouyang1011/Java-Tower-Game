// This script tests if the character is trying to see the details of the stele outside tower, and close it will press space
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class to display instruction window
public class Instruction : MonoBehaviour {
	public GameObject instruction;
	private bool ifNextto;
	private bool ifOpen;
	private float time;

	// Use this for initialization
	void Start(){
		ifNextto = false;
		ifOpen = false;
		time = 0;
	}

	// Update is called every frame
	void Update(){
		time += Time.deltaTime;
		if (Input.GetAxis ("Open") != 0 && ifNextto == true && time > 1) {
			time = 0;
			instruction.SetActive (!ifOpen);
			GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement> ().SetMoveable (ifOpen);
			ifOpen = !ifOpen;
		}	
	}

	// Able to open instruction window when next to stele
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Player")) {
			ifNextto = true;
		}
	}

	// Disable to open instruction window when next to stele
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.CompareTag ("Player")) {
			ifNextto = false;
		}
	}
}
