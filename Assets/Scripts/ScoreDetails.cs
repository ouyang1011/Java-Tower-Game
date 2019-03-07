// This script displays the answered questions with scores in each Java area.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDetails : MonoBehaviour {
	public Text title;
	public Text point;
	public Text progressContent;
	private string button;
	
	// Use this for initialization
	void Start () {
		this.gameObject.SetActive(false);
		button = "";
	}
	
	// Update is called once per frame
	void Update(){
		if(Input.GetAxis("Open") != 0)
			this.gameObject.SetActive(false);
	}
	
	// Display the details according to floor name
	public void SelectButton(){
		this.gameObject.SetActive (true);
		title.text = button;
		switch (button) {
			case "Output":
				point.text = button + "\nScore: " + Player.outputP + "/" + Player.totaloutputP + "\n";
				progressContent.text = Player.outputProgress;
				break;
			case "Variable":
				point.text = button + "\nScore: " + Player.variableP + "/" + Player.totalvariableP + "\n";
				progressContent.text = Player.variableProgress;
				break;
			case "Input":
				point.text = button + "\nScore: " + Player.inputP + "/" + Player.totalinputP + "\n";
				progressContent.text = Player.inputProgress;
				break;
			case "Condition":
				point.text = button + "\nScore: " + Player.conditionP + "/" + Player.totalconditionP + "\n";
				progressContent.text = Player.conditionProgress;
				break;
			case "Switch":
				point.text = button + "\nScore: " + Player.switchP + "/" + Player.totalswitchP + "\n";
				progressContent.text = Player.switchProgress;
				break;
			case "While":
				point.text = button + "\nScore: " + Player.whileP + "/" + Player.totalwhileP + "\n";
				progressContent.text = Player.whileProgress;
				break;
			case "For":
				point.text = button + "\nScore: " + Player.forP + "/" + Player.totalforP + "\n";
				progressContent.text = Player.forProgress;
				break;
			case "Array":
				point.text = button + "\nScore: " + Player.arrayP + "/" + Player.totalarrayP + "\n";
				progressContent.text = Player.arrayProgress;
				break;
			case "Function":
				point.text = button + "\nScore: " + Player.functionP + "/" + Player.totalfunctionP + "\n";
				progressContent.text = Player.functionProgress;
				break;
			case "Class":
				point.text = button + "\nScore: " + Player.classP + "/" + Player.totalclassP + "\n";
				progressContent.text = Player.classProgress;
				break;
			case "Object":
				point.text = button + "\nScore: " + Player.objectP + "/" + Player.totalobjectP + "\n";
				progressContent.text = Player.objectProgress;
				break;
			case "Mixture":
				point.text = button + "\nScore: " + Player.mixtureP + "/" + Player.totalmixtureP + "\n";
				progressContent.text = Player.mixtureProgress;
				break;
			case "Final":
				point.text = button + "\nSscore: " + Player.bossP + "/" + Player.totalbossP + "\n";
				progressContent.text = Player.bossProgress;
				break;
		}
	}

	// Function to open the details according to floor name
	public void ClickButton(string buttonName){
		button = buttonName;
		SelectButton();
	}
}
