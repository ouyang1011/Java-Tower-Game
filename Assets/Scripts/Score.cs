// This script displays the scores in each types of Java questions at the end of game and the final grade he/she get
using UnityEngine;
using UnityEngine.UI;

// Class to diplay totally scores at the end
public class Score : MonoBehaviour {
	public Text Total;
	public Text Output;
	public Text Variable;
	public Text Input;
	public Text Condition;
	public Text While;
	public Text For;
	public Text Array;
	public Text Function;
	public Text Class;
	public Text Object;
	public Text Mixture;
	public Text Final;

	private float grade;

	// Use this for initialization
	void Start () {
		Output.text = Player.outputP + "/" + Player.totaloutputP;
		Variable.text = Player.variableP + "/" + Player.totalvariableP;
		Input.text = Player.inputP + "/" + Player.totalinputP;
		Condition.text = Player.conditionP + "/" + Player.totalconditionP;
		While.text = Player.whileP + "/" + Player.totalwhileP;
		For.text = Player.forP + "/" + Player.totalforP;
		Array.text = Player.arrayP + "/" + Player.totalarrayP;
		Function.text = Player.functionP + "/" + Player.totalfunctionP;
		Class.text = Player.classP + "/" + Player.totalclassP;
		Object.text = Player.objectP + "/" + Player.totalobjectP;
		Mixture.text = Player.mixtureP + "/" + Player.totalmixtureP;
		Final.text = Player.bossP + "/" + Player.totalbossP;

		// Caculate the grade
		grade = (float)Player.point/Player.totalpoint;
		if(grade > 0.9)
			Total.text = Player.point + "/" + Player.totalpoint + " (A)";
		else if(grade > 0.8)
			Total.text = Player.point + "/" + Player.totalpoint + " (B)";
		else if(grade > 0.6)
			Total.text = Player.point + "/" + Player.totalpoint + " (C)";
		else
			Total.text = Player.point + "/" + Player.totalpoint + " (D)";
	}
	
}
