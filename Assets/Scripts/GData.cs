// This script is used to store all the Java question Lists with different titles and types. It will return current List according to the floor number
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class to static data of java question and current floor
public static class GData {
	public static List<string> outputDoor = new List<string> ();
	public static List<string> outputFight = new List<string> ();
	public static List<string> variableDoor = new List<string> ();
	public static List<string> variableFight = new List<string> ();
	public static List<string> inputDoor = new List<string> ();
	public static List<string> inputFight = new List<string> ();
	public static List<string> conditionDoor = new List<string> ();
	public static List<string> conditionFight = new List<string> ();
	public static List<string> switchDoor = new List<string> ();
	public static List<string> switchFight = new List<string> ();
	public static List<string> whileDoor = new List<string> ();
	public static List<string> whileFight = new List<string> ();
	public static List<string> forDoor = new List<string> ();
	public static List<string> forFight = new List<string> ();
	public static List<string> arrayDoor = new List<string> ();
	public static List<string> arrayFight = new List<string> ();
	public static List<string> functionDoor = new List<string> ();
	public static List<string> functionFight = new List<string> ();
	public static List<string> classDoor = new List<string> ();
	public static List<string> classFight = new List<string> ();
	public static List<string> objectDoor = new List<string> ();
	public static List<string> objectFight = new List<string> ();
	public static List<string> mixtureDoor = new List<string> ();
	public static List<string> mixtureFight = new List<string> ();
	public static List<string> finalFight = new List<string> ();
	public static int floorNum = 0;
	public static string floorName = "";

	// Function to get floor name and questions range for fighting and opening doors
	public static string getFloorName(){
		switch (floorNum) {
		case 0: 
			floorName = "Outside Tower";
			break;
		case 1:
			floorName = "Output";
			break;
		case 2:
		case 3:
			floorName = "Variable";
			break;
		case 4:
		case 5:
			floorName = "Input";
			break;
		case 6:
		case 7:
			floorName = "Condition";
			break;
		case 8:
			floorName = "Switch";
			break;
		case 9:
		case 10:
			floorName = "While";
			break;
		case 11:
			floorName = "For";
			break;
		case 12:
		case 13:
			floorName = "Array";
			break;
		case 14:
			floorName = "Function";
			break;
		case 15:
		case 16:
			floorName = "Class";
			break;
		case 17:
			floorName = "Object";
			break;
		case 18:
		case 19:
			floorName = "Mixture";
			break;
		case 20:
			floorName = "Final";
			break;
		}

		return floorName;
	}

}
