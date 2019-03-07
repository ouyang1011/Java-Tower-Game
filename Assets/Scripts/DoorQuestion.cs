// This script will display the Java questions with type of door according to the floor name. After testing the option which the player selects is true or not, it will display: 
// 		“Congratulation!!!” if the player gets right answer; 
// 		“Wrong answer. One more time.” if the player gets wrong answer at first time
// 		“Wrong answer!” if the player gets wrong answer at second time
// Then, it will remove the question from current question List and store it with answer, options, correct answer, reason, and scores as progress
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.UIElements;

// Class to diplay Java question when opening a door
public class DoorQuestion : MonoBehaviour {
	private Text question;
	private Text buttonA;
	private Text buttonB;
	private Text buttonC;
	private Text reason;
	private string qRecord;
	private string aRecord;
	private string bRecord;
	private string cRecord;
	private string correctRecord;
	private string reasonRecord;

	private string[] questions;
	private string correctAns;
	private string answer = "";
	private DataGet dataget;
	private string questionId;
	private bool ifRight;
	private bool ifMain;
	private int count;
	private DataGet data;
	private string feedback;
	private int random;
	private int getPoint;
	private List<string> currentQuestion;
	private bool CloseCheck;

	// Use this for initialization
	void Start(){
		question = GameObject.FindGameObjectWithTag ("Question").GetComponent<Text> ();
		buttonA = GameObject.FindGameObjectWithTag ("ButtonA").GetComponent<Text> ();
		buttonB = GameObject.FindGameObjectWithTag ("ButtonB").GetComponent<Text> ();
		buttonC = GameObject.FindGameObjectWithTag ("ButtonC").GetComponent<Text> ();
		reason = GameObject.FindGameObjectWithTag ("Feedback").GetComponent<Text> ();
		questions = new string[]{"", "", "", "", "", ""};
		getPoint = 0;

		qRecord = "";
		aRecord = "";
		bRecord = "";
		cRecord = "";
		correctRecord = "";
		reasonRecord = "";
		CloseCheck = false;

		question.text = "";
		buttonA.text = "";
		buttonB.text = "";
		buttonC.text = "";
		reason.text = "";
		feedback = "";
		ifRight = false;
		random = -1;
		data = new DataGet ();
		count = 0;

		this.gameObject.SetActive (false);

	}

	// Update is called every frame
	void Update(){
		// Test if the door question window can be disabled
		if (CloseCheck) {
            if(Input.GetButtonDown ("Open")) {
				this.gameObject.SetActive (false);
				random = -1;
				CloseCheck = false;
				count = 0;
			}
		}

		// Randomly get questions according to floor num
		if (random == -1) {
			switch (GData.getFloorName()) {
				case "Output":
					random = Random.Range (0, GData.outputDoor.Count - 1);
					questionId = GData.outputDoor[random];
					GData.outputDoor.Remove(questionId);
					break;
				case "Variable":
					random = Random.Range (0, GData.variableDoor.Count - 1);
					questionId = GData.variableDoor[random];
					GData.variableDoor.Remove(questionId);
					break;
				case "Input":
					random = Random.Range (0, GData.inputDoor.Count - 1);
					questionId = GData.inputDoor[random];
					GData.inputDoor.Remove(questionId);
					break;
				case "Condition":
					random = Random.Range (0, GData.conditionDoor.Count - 1);
					questionId = GData.conditionDoor[random];
					GData.conditionDoor.Remove(questionId);
					break;
				case "Switch":
					random = Random.Range (0, GData.switchDoor.Count - 1);
					questionId = GData.switchDoor[random];
					GData.switchDoor.Remove(questionId);
					break;
				case "While":
					random = Random.Range (0, GData.whileDoor.Count - 1);
					questionId = GData.whileDoor[random];
					GData.whileDoor.Remove(questionId);
					break;
				case "For":
					random = Random.Range (0, GData.forDoor.Count - 1);
					questionId = GData.forDoor[random];
					GData.forDoor.Remove(questionId);
					break;
				case "Array":
					random = Random.Range (0, GData.arrayDoor.Count - 1);
					questionId = GData.arrayDoor[random];
					GData.arrayDoor.Remove(questionId);
					break;
				case "Function":
					random = Random.Range (0, GData.functionDoor.Count - 1);
					questionId = GData.functionDoor[random];
					GData.functionDoor.Remove(questionId);
					break;
				case "Class":
					random = Random.Range (0, GData.classDoor.Count - 1);
					questionId = GData.classDoor[random];
					GData.classDoor.Remove(questionId);
					break;
				case "Object":
					random = Random.Range (0, GData.objectDoor.Count - 1);
					questionId = GData.objectDoor[random];
					GData.objectDoor.Remove(questionId);
					break;
				case "Mixture":
					random = Random.Range (0, GData.mixtureDoor.Count - 1);
					questionId = GData.mixtureDoor[random];
					GData.mixtureDoor.Remove(questionId);
					break;
			}
			
			questions = data.GetChoiceQuestion (questionId).Split ('|');
			question.text = questions [0];
			buttonA.text = questions [1];
			buttonB.text = questions [2];
			buttonC.text = questions [3];
			correctAns = questions [4];
			reason.text = "";
			feedback = questions [5];

			qRecord = questions[0];
			aRecord = questions[1];
			bRecord = questions[2];
			cRecord = questions[3];
			correctRecord = questions[4];
			reasonRecord = questions[5];
		}
	}
		
	// Test if the answer is correct	
	public void Answer(string ans){
		answer = ans;
		count++;

		if(count < 3) {					
			// When answer is correct at first time
			if (count == 1 && answer == correctAns) {
				reason.text = "Congratulations!!!";
				Player.exp += 10;
				getPoint = 100;
				CloseCheck = true;
				ifRight = true;
				GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement> ().ChangeFeedback ("You got 10 experiences.");
			// When answer is correct at second time
			} else if (count == 2 && answer == correctAns) {
				reason.text = "Congratulations!!!";
				Player.exp += 5;
				CloseCheck = true;
				getPoint = 50;
				ifRight = true;
				GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement> ().ChangeFeedback ("You got 5 experiences.");
			} else if (count == 2 && answer != correctAns){
				reason.text = "Wrong Answer!\n" + feedback;
				getPoint = 0;
				ifRight = true;
				CloseCheck = true;
				GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement> ().ChangeFeedback ("You got 0 experiences.");
			} else if(count == 1 && answer != correctAns){
				reason.text = "Wrong Answer! One more chance.";
			}				

			if(ifRight){
				Player.totalpoint += 100;
				// Store data to progress class according to floor number
				switch (GData.floorNum) {
					case 1:
						Player.outputProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
						Player.outputP += getPoint;
						Player.point += getPoint;
						Player.totaloutputP += 100;
						break;
					case 2:
					case 3:
						Player.variableProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
						Player.variableP += getPoint;
						Player.point += getPoint;
						Player.totalvariableP += 100;
						break;
					case 4:
					case 5:
						Player.inputProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
						Player.inputP += getPoint;
						Player.point += getPoint;
						Player.totalinputP += 100;
						break;
					case 6:
					case 7:
						Player.conditionProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
						Player.conditionP += getPoint;
						Player.point += getPoint;
						Player.totalconditionP += 100;
						break;
					case 8:
						Player.switchProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
						Player.switchP += getPoint;
						Player.point += getPoint;
						Player.totalswitchP += 100;
						break;
					case 9:
					case 10:
						Player.whileProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
						Player.whileP += getPoint;
						Player.point += getPoint;
						Player.totalwhileP += 100;
						break;
					case 11:
						Player.forProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
						Player.forP += getPoint;
						Player.point += getPoint;
						Player.totalforP += 100;
						break;
					case 12:
					case 13:
						Player.arrayProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
						Player.arrayP += getPoint;
						Player.point += getPoint;
						Player.totalarrayP += 100;
						break;
					case 14:
						Player.functionProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
						Player.functionP += getPoint;
						Player.point += getPoint;
						Player.totalfunctionP += 100;
						break;
					case 15:
					case 16:
						Player.classProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
						Player.classP += getPoint;
						Player.point += getPoint;
						Player.totalclassP += 100;
						break;
					case 17:
						Player.objectProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
						Player.objectP += getPoint;
						Player.point += getPoint;
						Player.totalobjectP += 100;
						break;
					case 18:
					case 19:
						Player.mixtureProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
						Player.mixtureP += getPoint;
						Player.point += getPoint;
						Player.totalmixtureP += 100;
						break;
				}
					ifRight = false;
					answer = "";
				}		
		}
	}

	// Function to change the number left to anwer the questions
	public void ChangeCount(int c){
		count = c;
	}
}
