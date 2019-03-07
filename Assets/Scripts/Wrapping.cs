// This script is a cheat which is used to pass each floor at one second during presentations
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Class to cheat on passing each floor
public class Wrapping : MonoBehaviour {
	public GameObject[] endPostions;

	// Update is called once per frame
	void Update(){
		// Press 'j' to near to the upstair
		if (Input.GetButtonDown ("Quickway")) {
			GameObject.FindGameObjectWithTag ("Player").gameObject.transform.position = endPostions[GData.floorNum].transform.position;
		}
	}
}
