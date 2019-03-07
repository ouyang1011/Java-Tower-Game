// This script is used when the player loses, and it shows the grade, scorces and where the character died in the Game Over window
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Class to disply Game Over window
public class GameOver : MonoBehaviour {
	public Text progress;
	private float calculate;
	private string grade;
	
	// Update is called once per frame
	void Update () {
		// Calculate grade
		calculate = (float)Player.point/Player.totalpoint;
		if(calculate > 0.9)
			grade = "A";
		else if(calculate > 0.8)
			grade = "B";
		else if(calculate > 0.6)
			grade = "C";
		else
			grade = "D";

		// Disply score with floor number and grade
		progress.text = "Your deid on floor: " + GData.floorNum + " (" + GData.getFloorName() +")"+ "  The grade: (" + grade + ")";
	}
}
