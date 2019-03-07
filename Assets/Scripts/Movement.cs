// This script is used to control the character's movements and close Feedback windows 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Class to control character movements
public class Movement : MonoBehaviour {
	private float speed = 60f;
	private float direction = 0;
	private Animator player;
	private Vector2 move;
	private bool ifMoveable;
	private float time;
	public GameObject fightScreen;
	public GameObject doorScreen;
	public GameObject playerPosition;
	public GameObject feedback;
	public Text feedbackDetail;

	// Use this for initialization
	void Start () {
		player = gameObject.GetComponent<Animator> (); 
		gameObject.layer = 0;
		gameObject.GetComponent<Rigidbody2D> ().freezeRotation = true;
		move = Vector2.zero;
		ifMoveable = true;
		if (!Player.ifUpStair) {
			Player.ifUpStair = true;
			this.gameObject.transform.position = playerPosition.transform.position;
		}
	}

	// Update is called once per frame
	void Update () {
		if(ifMoveable)
			Move ();
		else{
			if (Input.GetAxis ("Open") != 0)
				ifMoveable = true;
		}

		if (Input.GetAxis ("Open") != 0) {
			feedback.SetActive (false);
		}
    }

	// Function to move up, down, left, and right with animations
	void Move () {
		float h = 0;

		if (Input.GetAxis ("Horizontal") != 0) {
			h = Input.GetAxis ("Horizontal");
			direction = 1;

			move = Vector2.right * h;
		} else if (Input.GetAxis ("Vertical") != 0) {
			h = Input.GetAxis ("Vertical");
			direction = -1;

			move = Vector2.up * h;
		} else {
			move = Vector2.zero;
		}

		transform.Translate (move * speed * Time.deltaTime);
		player.SetFloat ("Speed", h);
		player.SetFloat ("Direction", direction);
	}

	// Set if the character can move
	public void SetMoveable(bool move){
		ifMoveable = move;
	}

	// Display the feedback when finishing a fight, opening a door, or using a crystal
	public void ChangeFeedback(string x){
		feedback.SetActive (true);
		feedbackDetail.text = x;
		ifMoveable = false;
	}
}
