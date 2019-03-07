// This script tests if the character is engaged to a stair and check if the stair is a upstair
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Class to go upstair or downstair
public class Stair : MonoBehaviour {
	public int floorChange;
	public Transform nextPos;
	public Transform cameraTarget;
	private float time = 0;
	private bool ifMove;

	// Test if character use the stair
	void OnTriggerEnter2D(Collider2D other){
		ifMove = true;
		GData.floorNum += floorChange;
		GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement> ().SetMoveable (false);
		time = 0;
		other.gameObject.transform.position = nextPos.position;
		Camera.main.transform.position = new Vector3(cameraTarget.position.x, cameraTarget.position.y, -10f);
	}

	// Update is called once per frame
	void Update(){
		if(!ifMove){
			if (time < 10) {
				time += Time.deltaTime;
			} else {
				GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement> ().SetMoveable (true);
				time = 0;
				ifMove = true;
			}
		}
	}
}
