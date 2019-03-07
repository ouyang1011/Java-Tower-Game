// This script will create the save.txt file(if there is not save.txt) and store all the data to it
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

// Class to save the game
public class Saving : MonoBehaviour {
	private string order;

	// Function to save all the data
	public void SavingGame(){
		// Create a file to save when it does not exist
		FileStream myfile = File.Open("save.txt", FileMode.Create);
		StreamWriter mySave = new StreamWriter(myfile);
        Player.playerM = GameObject.FindGameObjectWithTag("Player").transform.position;
        Player.cameraM = Camera.main.transform.position;
        mySave.WriteLine(Player.health);	
		mySave.WriteLine(Player.maxH);
		mySave.WriteLine(Player.attack);
		mySave.WriteLine(Player.defense);
		mySave.WriteLine(Player.exp);
		mySave.WriteLine(Player.maxE);
        mySave.WriteLine(Player.cameraM.x);
        mySave.WriteLine(Player.cameraM.y);
        mySave.WriteLine(Player.cameraM.z);
        mySave.WriteLine(Player.playerM.x);
        mySave.WriteLine(Player.playerM.y);
        mySave.WriteLine(Player.playerM.z);
        mySave.WriteLine(GData.floorNum);
        mySave.WriteLine(GData.floorName);
        mySave.WriteLine(Player.point);
		mySave.WriteLine(Player.outputP);
		mySave.WriteLine(Player.variableP);
		mySave.WriteLine(Player.inputP);
		mySave.WriteLine(Player.conditionP);
		mySave.WriteLine(Player.switchP);
		mySave.WriteLine(Player.whileP);
		mySave.WriteLine(Player.forP);
		mySave.WriteLine(Player.arrayP);
		mySave.WriteLine(Player.functionP);
		mySave.WriteLine(Player.classP);
		mySave.WriteLine(Player.objectP);
		mySave.WriteLine(Player.mixtureP);
		mySave.WriteLine(Player.bossP);
		mySave.WriteLine(Player.totalpoint);
		mySave.WriteLine(Player.totaloutputP);
		mySave.WriteLine(Player.totalvariableP);
		mySave.WriteLine(Player.totalinputP);
		mySave.WriteLine(Player.totalconditionP);
		mySave.WriteLine(Player.totalswitchP);
		mySave.WriteLine(Player.totalwhileP);
		mySave.WriteLine(Player.totalforP);
		mySave.WriteLine(Player.totalarrayP);
		mySave.WriteLine(Player.totalfunctionP);
		mySave.WriteLine(Player.totalclassP);
		mySave.WriteLine(Player.totalobjectP);
		mySave.WriteLine(Player.totalmixtureP);
        mySave.WriteLine(Player.totalbossP);

        // Save quetions which not answereds
        foreach (string i in GData.outputDoor)
        {
            order = order + "|" + i;
        }
		mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.outputFight)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.variableDoor)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.variableFight)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.inputDoor)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.inputFight)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.conditionDoor)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.conditionFight)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.switchDoor)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.switchFight)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.whileDoor)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.whileFight)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.forDoor)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.forFight)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.arrayDoor)
        {
            order = order + "|" + i;
        }
		mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.arrayFight)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.functionDoor)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.functionFight)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.classDoor)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.classFight)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.objectDoor)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.objectFight)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.mixtureDoor)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";
        foreach (string i in GData.mixtureFight)
        {
            order = order + "|" + i;
        }
        mySave.WriteLine(order);
		order = "";

        mySave.WriteLine("O" + Player.outputProgress + "/");
        mySave.WriteLine("V" + Player.variableProgress + "/");
        mySave.WriteLine("I" + Player.inputProgress + "/");
        mySave.WriteLine("C" + Player.conditionProgress + "/");
        mySave.WriteLine("S" + Player.switchProgress + "/");
        mySave.WriteLine("W" + Player.whileProgress + "/");
        mySave.WriteLine("F" + Player.forProgress + "/");
        mySave.WriteLine("A" + Player.arrayProgress + "/");
        mySave.WriteLine("U" + Player.functionProgress + "/");
        mySave.WriteLine("L" + Player.classProgress + "/");
        mySave.WriteLine("B" + Player.objectProgress + "/");
        mySave.WriteLine("M" + Player.mixtureProgress + "/");

        foreach (string ob in Player.stuffs){
            order = order + "|" + ob;
        }
        mySave.WriteLine(order);
        order = "";

        mySave.Flush();
		mySave.Close();
	}
}
