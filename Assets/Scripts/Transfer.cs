// This script provides the transfer which the character can move to particular location when use it
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class to use transfer
public class Transfer : MonoBehaviour {
	public Transform transferT;
	private float time;
	private bool ifTransfer;

	// Use this for initialization
	void Start(){
		time = 0;
		ifTransfer = false;
	}

	// Update is called once per frame
	void Update(){
		if(ifTransfer){
			time += Time.deltaTime;
			if (time > 2) {
				ifTransfer = false;
				time = 0;
				GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement> ().SetMoveable (true);
			}
		}
	}

	// Test if character is using the transfer
	void OnTriggerEnter2D(Collider2D other){
		GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement> ().SetMoveable (false);
		other.gameObject.transform.position = transferT.position;
		ifTransfer = true;
	}
}
