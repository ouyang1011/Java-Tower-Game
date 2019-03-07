// This script will display the Java questions with type of fight according to the floor name. After testing the option which the player selects is true or not, it will display: 
// 		“Congratulation!!!” if the player gets right answer and it will increase the character's status temporary in this fight; 
// 		“Wrong answer.” if the player gets wrong answer and nothing will changes
// Then, it will remove the question from current question List and store it with answer, options, correct answer, reason, and scores as progress, then go to the fighting part
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;

// Class to display fight Java questions
public class FightQuestion : MonoBehaviour {
	private Text question;
	private Text buttonA;
	private Text buttonB;
	private Text buttonC;
	private Text reason;
	private string correctAns;
	private string answer = "";
	private DataGet dataget;
	private string questionId;
	private DataGet data;
	private string feedback;
	private int random;
	private int getPoint;
	private Animator anim;

	private string qRecord;
	private string aRecord;
	private string bRecord;
	private string cRecord;
	private string correctRecord;
	private string reasonRecord;

	// Use this for initialization
	void Start(){
		random = -1;
		data = new DataGet ();
		question = GameObject.FindGameObjectWithTag ("QuestionF").GetComponent<Text> ();
		buttonA = GameObject.FindGameObjectWithTag ("ButtonAF").GetComponent<Text> ();
		buttonB = GameObject.FindGameObjectWithTag ("ButtonBF").GetComponent<Text> ();
		buttonC = GameObject.FindGameObjectWithTag ("ButtonCF").GetComponent<Text> ();
		reason = GameObject.FindGameObjectWithTag ("ReasonF").GetComponent<Text> ();
		anim = GameObject.FindGameObjectWithTag("Fighting").GetComponent<Animator>();

		question.text = "";
		buttonA.text = "";
		buttonB.text = "";
		buttonC.text = "";
		reason.text = "";
		feedback = "";

		qRecord = "";
		aRecord = "";
		bRecord = "";
		cRecord = "";
		correctRecord = "";
		reasonRecord = "";
	}

	// Update is called every frame
	void Update(){
		if (answer != "") {
			// When the answer is right
			if (answer == correctAns) {
				reason.text = "Congratulations!!!";
				getPoint = 5;
				GameObject.FindGameObjectWithTag ("Fighting").GetComponent<Fighting> ().Change (true);
			// When the answer is wrong	
			} else {
				reason.text = "Wrong answer.\n" + feedback;
				getPoint = 0;
				GameObject.FindGameObjectWithTag ("Fighting").GetComponent<Fighting> ().Change (false);
			}

			// Store point and object to prograss class
			Player.totalpoint += 50;
			switch (GData.floorNum) {
				case 1:
					Player.outputProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
					Player.outputP += getPoint;
					Player.point += getPoint;
					Player.totaloutputP += 50;
					break;
				case 2:
				case 3:
					Player.variableProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
					Player.variableP += getPoint;
					Player.point += getPoint;
					Player.totalvariableP += 50;
					break;
				case 4:
				case 5:
					Player.inputProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
					Player.inputP += getPoint;
					Player.point += getPoint;
					Player.totalinputP += 50;
					break;
				case 6:
				case 7:
					Player.conditionProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
					Player.conditionP += getPoint;
					Player.point += getPoint;
					Player.totalconditionP += 50;
					break;
				case 8:
					Player.switchProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
					Player.switchP += getPoint;
					Player.point += getPoint;
					Player.totalswitchP += 50;
					break;
				case 9:
				case 10:
					Player.whileProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
					Player.whileP += getPoint;
					Player.point += getPoint;
					Player.totalwhileP += 50;
					break;
				case 11:
					Player.forProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
					Player.forP += getPoint;
					Player.point += getPoint;
					Player.totalforP += 50;
					break;
				case 12:
				case 13:
					Player.arrayProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
					Player.arrayP += getPoint;
					Player.point += getPoint;
					Player.totalarrayP += 50;
					break;
				case 14:
					Player.functionProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
					Player.functionP += getPoint;
					Player.point += getPoint;
					Player.totalfunctionP += 50;
					break;
				case 15:
				case 16:
					Player.classProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
					Player.classP += getPoint;
					Player.point += getPoint;
					Player.totalclassP += 50;
					break;
				case 17:
					Player.objectProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
					Player.objectP += getPoint;
					Player.point += getPoint;
					Player.totalobjectP += 50;
					break;
				case 18:
				case 19:
					Player.mixtureProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
					Player.mixtureP += getPoint;
					Player.point += getPoint;
					Player.totalmixtureP += 50;
					break;
				case 20:
					Player.bossProgress += "Question: " + qRecord + "\nOption: " + aRecord + "\n" + bRecord + "\n" + cRecord + "\nCorrect Answer: " + correctRecord + "\nReason: " + reasonRecord + "\nGet Point: " + getPoint + "\n";
					Player.bossP += getPoint;
					Player.point += getPoint;
					Player.totalbossP += 50;
					break;
			}

			answer = "";
		}
		// Randomly display Java question when fightings
		if (random == -1) {
			switch (GData.getFloorName()) {
				case "Output":
					random = Random.Range (0, GData.outputFight.Count - 1);
					questionId = GData.outputFight[random];
					GData.outputFight.Remove(questionId);
					break;
				case "Variable":
					random = Random.Range (0, GData.variableFight.Count - 1);
					questionId = GData.variableFight[random];
					GData.variableFight.Remove(questionId);
					break;
				case "Input":
					random = Random.Range (0, GData.inputFight.Count - 1);
					questionId = GData.inputFight[random];
					GData.inputFight.Remove(questionId);
					break;
				case "Condition":
					random = Random.Range (0, GData.conditionFight.Count - 1);
					questionId = GData.conditionFight[random];
					GData.conditionFight.Remove(questionId);
					break;
				case "Switch":
					random = Random.Range (0, GData.switchFight.Count - 1);
					questionId = GData.switchFight[random];
					GData.switchFight.Remove(questionId);
					break;
				case "While":
					random = Random.Range (0, GData.whileFight.Count - 1);
					questionId = GData.whileFight[random];
					GData.whileFight.Remove(questionId);
					break;
				case "For":
					random = Random.Range (0, GData.forFight.Count - 1);
					questionId = GData.forFight[random];
					GData.forFight.Remove(questionId);
					break;
				case "Array":
					random = Random.Range (0, GData.arrayFight.Count - 1);
					questionId = GData.arrayFight[random];
					GData.arrayFight.Remove(questionId);
					break;
				case "Function":
					random = Random.Range (0, GData.functionFight.Count - 1);
					questionId = GData.functionFight[random];
					GData.functionFight.Remove(questionId);
					break;
				case "Class":
					random = Random.Range (0, GData.classFight.Count - 1);
					questionId = GData.classFight[random];
					GData.classFight.Remove(questionId);
					break;
				case "Object":
					random = Random.Range (0, GData.objectFight.Count - 1);
					questionId = GData.objectFight[random];
					GData.objectFight.Remove(questionId);
					break;
				case "Mixture":
					random = Random.Range (0, GData.mixtureFight.Count - 1);
					questionId = GData.mixtureFight[random];
					GData.mixtureFight.Remove(questionId);
					break;
				default:
					random = Random.Range (0, GData.finalFight.Count - 1);
					questionId = GData.finalFight[random];
					GData.finalFight.Remove(questionId);
					break;
			}
			string[] questions = data.GetChoiceQuestion (questionId).Split ('|');

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
        else if (Input.GetButtonDown ("Open")) {
			random = -1;
			anim.SetInteger("State", 1);
			this.gameObject.SetActive(false);
		}
	}

	public void Answer(string ans){
		answer = ans;
	}
}
