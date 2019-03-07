// This script is used to leave the game. If player clicks the Exit button on
//		Main Menu scene: It will leave the game
//		Levels scene: It will back to Main Menu
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Class to leave the game
public class Exit : MonoBehaviour {

	// Leave game int Main menu
	public void ExitGame(){
		Application.Quit ();
	}

	// Go back to Main menu during game
	public void ExitGameDuringGame(){
		SceneManager.LoadScene (0);
	}
}
