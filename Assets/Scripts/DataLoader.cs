// This script gets all the data of question table from Java_Tower database online and store them to different Lists according to their titles and types
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// class to get data of question table from database
public class DataLoader : MonoBehaviour {
	private string[] questionList;

	// Use this for initialization
	IEnumerator Start () {
		// Get all the date from the website
		WWW questionData = new WWW ("http://javatowergame.000webhostapp.com/questionData.php");
		yield return questionData;

		string questionDataString = questionData.text;
		questionList = questionDataString.Split (';');

		string group = "";
		// Group the ID with questions' types
		for (int i = 0; i < questionList.Length - 1; i++) {
			group = questionList [i].Substring (questionList [i].IndexOf ('/') + 1);
			switch (group) {
			case "Output|door":
				GData.outputDoor.Add ((i + 1) + "");
				break;
			case "Output|fight":
				GData.outputFight.Add ((i + 1) + "");
				break;
			case "Variable|door":
				GData.variableDoor.Add ((i + 1) + "");
				break;
			case "Variable|fight":
				GData.variableFight.Add ((i + 1) + "");
				break;
			case "Input|door":
				GData.inputDoor.Add ((i + 1) + "");
				break;
			case "Input|fight":
				GData.inputFight.Add ((i + 1) + "");
				break;
			case "Condition|door":
				GData.conditionDoor.Add ((i + 1) + "");
				break;
			case "Condition|fight":
				GData.conditionFight.Add ((i + 1) + "");
				break;
			case "Switch|door":
				GData.switchDoor.Add ((i + 1) + "");
				break;
			case "Switch|fight":
				GData.switchFight.Add ((i + 1) + "");
				break;
			case "While|door":
				GData.whileDoor.Add ((i + 1) + "");
				break;
			case "While|fight":
				GData.whileFight.Add ((i + 1) + "");
				break;
			case "For|door":
				GData.forDoor.Add ((i + 1) + "");
				break;
			case "For|fight":
				GData.forFight.Add ((i + 1) + "");
				break;
			case "Array|door":
				GData.arrayDoor.Add ((i + 1) + "");
				break;
			case "Array|fight":
				GData.arrayFight.Add ((i + 1) + "");
				break;
			case "Function|door":
				GData.functionDoor.Add ((i + 1) + "");
				break;
			case "Function|fight":
				GData.functionFight.Add ((i + 1) + "");
				break;
			case "Class|door":
				GData.classDoor.Add ((i + 1) + "");
				break;
			case "Class|fight":
				GData.classFight.Add ((i + 1) + "");
				break;
			case "Object|door":
				GData.objectDoor.Add ((i + 1) + "");
				break;
			case "Object|fight":
				GData.objectFight.Add ((i + 1) + "");
				break;
			case "Mixture|door":
				GData.mixtureDoor.Add ((i + 1) + "");
				break;
			case "Mixture|fight":
				GData.mixtureFight.Add ((i + 1) + "");
				break;
			case "Final|fight":
				GData.finalFight.Add ((i + 1) + "");
				break;
			}
		}
	}
}
