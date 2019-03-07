// This script is used to control the speed of storyline and when it can go to next storyline/level
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Class about storyline
public class StoryLine : MonoBehaviour {
	private Animator story;
	private bool isNext;
	private float time;
	public GameObject back1;
	public Text instruction;
	public GameObject story1;
	public GameObject story2;

	// Use this for initialization
	void Start () {
		story = GetComponent<Animator> ();
		isNext = false;
		time = 0;
		instruction.text = "Press '→' key to fast forward.";
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > 15) {
			// Press -> to fast forword
			instruction.text = "Press 'space' key to go next.";
			if (Input.GetAxis ("Open") != 0) {
                if (!isNext)
                {
                    story.SetTrigger("Next");
                    instruction.text = "Press '→' key to fast forward.";
                    isNext = true;
                }
                else
                {
                    SceneManager.LoadScene(3);
                }
				time = 0;
			}
		}
		if (Input.GetAxis ("Horizontal") == 1) {
			story.speed = 3.0f;
			time += Time.deltaTime * 3;
		} else if (Input.GetAxis ("Horizontal") == 0) {
			story.speed = 1.0f;
		}
	}

	// Change the first storyline to second
	void ChangeActive(){
		back1.SetActive (false);
		story1.SetActive (false);
		story2.SetActive (true);
	}
}
