// This script provides the method to change to another level of this game
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Class is to change levels during game
public class ChangeScene : MonoBehaviour {

	// Function will load a scene according to the int argument
	public void LoadScene(int scene){ 
		SceneManager.LoadScene (scene);
	}

    // Function will load the saving file
    public void LoadScene(){
        SceneManager.LoadScene(3);
        Player.ifLoad = true;
    }
}
