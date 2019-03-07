// This script stores the character status including locations, health, attack and defense power, and experiences, and the scores and questions he/she got
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Static class of character's status and point with progress
public static class Player {
	public static List<string> stuffs = new List<string> ();
	public static List<string> aWeapon = new List<string> (){"Empty"};
	public static List<string> dWeapon = new List<string> (){"Empty"};

	// Variables for level, floor number, and locations of camera and character
	public static int level;
	public static int floor;

	public static int health = 100;
	public static int maxH = 100;
	public static int attack = 10;
	public static int defense = 5;
	public static int equipmentAttack = 0;
	public static int equipmentDefense = 0;
	public static int exp = 0;
	public static int maxE = 100;
	public static bool ifUpStair = true;
	public static int point = 0;
	public static int outputP = 0;
	public static int variableP = 0;
	public static int inputP = 0;
	public static int conditionP = 0;
	public static int switchP = 0;
	public static int whileP = 0;
	public static int forP = 0;
	public static int arrayP = 0;
	public static int functionP = 0;
	public static int classP = 0;
	public static int objectP = 0;
	public static int mixtureP = 0;
	public static int bossP = 0;

	public static int totalpoint = 0;
	public static int totaloutputP = 0;
	public static int totalvariableP = 0;
	public static int totalinputP = 0;
	public static int totalconditionP = 0;
	public static int totalswitchP = 0;
	public static int totalwhileP = 0;
	public static int totalforP = 0;
	public static int totalarrayP = 0;
	public static int totalfunctionP = 0;
	public static int totalclassP = 0;
	public static int totalobjectP = 0;
	public static int totalmixtureP = 0;
	public static int totalbossP = 0;

	public static string outputProgress = "";
	public static string variableProgress = "";
	public static string inputProgress = "";
	public static string conditionProgress = "";
	public static string switchProgress = "";
	public static string whileProgress = "";
	public static string forProgress = "";
	public static string arrayProgress = "";
	public static string functionProgress = "";
	public static string classProgress = "";
	public static string objectProgress = "";
	public static string mixtureProgress ="";
	public static string bossProgress = "";
    public static bool ifLoad;
    public static Vector3 cameraM;
    public static Vector3 playerM;

	// Function to initilize the game 
	public static void Init(){
		stuffs = new List<string> ();
		aWeapon = new List<string> ();
		dWeapon = new List<string> ();

		aWeapon = new List<string> (){ "Empty" };
		dWeapon = new List<string> (){ "Empty" };

		health = 100;
		maxH = 100;
		attack = 10;
		defense = 5;
		equipmentAttack = 0;
		equipmentDefense = 0;
		exp = 0;
		maxE = 100;
		point = 0;
		outputP = 0;
		variableP = 0;
		inputP = 0;
		conditionP = 0;
		switchP = 0;
		whileP = 0;
		forP = 0;
		arrayP = 0;
		functionP = 0;
		classP = 0;
		objectP = 0;
		mixtureP = 0;
		bossP = 0;

		totalpoint = 0;
		totaloutputP = 0;
		totalvariableP = 0;
		totalinputP = 0;
		totalconditionP = 0;
		totalswitchP = 0;
		totalwhileP = 0;
		totalforP = 0;
		totalarrayP = 0;
		totalfunctionP = 0;
		totalclassP = 0;
		totalobjectP = 0;
		totalmixtureP = 0;
		totalbossP = 0;

		outputProgress = "";
		variableProgress = "";
		inputProgress = "";
		conditionProgress = "";
		switchProgress = "";
		whileProgress = "";
		forProgress = "";
		arrayProgress = "";
		functionProgress = "";
		classProgress = "";
		objectProgress = "";
		mixtureProgress ="";
		bossProgress ="";
	}
}
