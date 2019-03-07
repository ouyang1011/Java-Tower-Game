// This script tests if the character is trying to get an equipment
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Class about equipments
public class Weapon : MonoBehaviour {
	private bool isGet;
	public string type;
	public string wName;
	private PlayerStatus player;

	// Use this for initialization
	void Start () {
		isGet = false;
		player = GameObject.FindGameObjectWithTag ("Status").GetComponent<PlayerStatus> ();
	}
	
	// Update is called once per frame
	void Update () {
		// Add the equipment to dropdowm menu
		if (isGet) {
			player.GetWeapon (type, wName);
			isGet = false;
			Player.stuffs.Add (this.gameObject.name);
			this.gameObject.SetActive (false);
		}
	}

	// Test if the equipment is gotten
	void OnTriggerEnter2D(Collider2D other){
		isGet = true;
	}
}
