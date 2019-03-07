// This script reads all the data which stores in a sava.txt if the file exist
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

// Class to load the game
public class Loading : MonoBehaviour {
    private string content = "";
    private float x1;
    private float y1;
    private float z1;
    private float x2;
    private float y2;
    private float z2;
    string[] newList;
    List<string> data;

    // Loading all using objects and status, points, and progress of player
    public void LoadingGame(){
        if (File.Exists("save.txt")){
            using (StreamReader myLoad = new StreamReader("save.txt"))
            {
                Player.health = int.Parse(myLoad.ReadLine());
                Player.maxH = int.Parse(myLoad.ReadLine());
                Player.attack = int.Parse(myLoad.ReadLine());
                Player.defense = int.Parse(myLoad.ReadLine());
                Player.exp = int.Parse(myLoad.ReadLine());
                Player.maxE = int.Parse(myLoad.ReadLine());
                x1 = float.Parse(myLoad.ReadLine());
                y1 = float.Parse(myLoad.ReadLine());
                z1 = float.Parse(myLoad.ReadLine());
                x2 = float.Parse(myLoad.ReadLine());
                y2 = float.Parse(myLoad.ReadLine());
                z2 = float.Parse(myLoad.ReadLine());
                Player.cameraM = new Vector3(x1, y1, z1);
                Player.playerM = new Vector3(x2, y2, z2);
                GData.floorNum = int.Parse(myLoad.ReadLine());
                GData.floorName = myLoad.ReadLine();
                Player.point = int.Parse(myLoad.ReadLine());
                Player.outputP = int.Parse(myLoad.ReadLine());
                Player.variableP = int.Parse(myLoad.ReadLine());
                Player.inputP = int.Parse(myLoad.ReadLine());
                Player.conditionP = int.Parse(myLoad.ReadLine());
                Player.switchP = int.Parse(myLoad.ReadLine());
                Player.whileP = int.Parse(myLoad.ReadLine());
                Player.forP = int.Parse(myLoad.ReadLine());
                Player.arrayP = int.Parse(myLoad.ReadLine());
                Player.functionP = int.Parse(myLoad.ReadLine());
                Player.classP = int.Parse(myLoad.ReadLine());
                Player.objectP = int.Parse(myLoad.ReadLine());
                Player.mixtureP = int.Parse(myLoad.ReadLine());
                Player.bossP = int.Parse(myLoad.ReadLine());
                Player.totalpoint = int.Parse(myLoad.ReadLine());
                Player.totaloutputP = int.Parse(myLoad.ReadLine());
                Player.totalvariableP = int.Parse(myLoad.ReadLine());
                Player.totalinputP = int.Parse(myLoad.ReadLine());
                Player.totalconditionP = int.Parse(myLoad.ReadLine());
                Player.totalswitchP = int.Parse(myLoad.ReadLine());
                Player.totalwhileP = int.Parse(myLoad.ReadLine());
                Player.totalforP = int.Parse(myLoad.ReadLine());
                Player.totalarrayP = int.Parse(myLoad.ReadLine());
                Player.totalfunctionP = int.Parse(myLoad.ReadLine());
                Player.totalclassP = int.Parse(myLoad.ReadLine());
                Player.totalobjectP = int.Parse(myLoad.ReadLine());
                Player.totalmixtureP = int.Parse(myLoad.ReadLine());
                Player.totalbossP = int.Parse(myLoad.ReadLine());

                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.outputDoor.Add(i);
                }

                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.outputFight.Add(i);
                }

                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.variableDoor.Add(i);
                }

                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.variableFight.Add(i);
                }

                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.inputDoor.Add(i);
                }

                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.inputFight.Add(i);
                }

                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.conditionDoor.Add(i);
                }

                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.conditionFight.Add(i);
                }

                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.switchDoor.Add(i);
                }

                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.switchFight.Add(i);
                }

                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.whileDoor.Add(i);
                }

                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.whileFight.Add(i);
                }
                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.forDoor.Add(i);
                }
                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.forFight.Add(i);
                }
                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.arrayDoor.Add(i);
                }
                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.arrayFight.Add(i);
                }
                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.functionDoor.Add(i);
                }
                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.functionFight.Add(i);
                }
                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.classDoor.Add(i);
                }
                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.classFight.Add(i);
                }
                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.objectDoor.Add(i);
                }
                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.objectFight.Add(i);
                }
                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.mixtureDoor.Add(i);
                }
                newList = myLoad.ReadLine().Substring(1).Split('|');
                foreach (string i in newList)
                {
                    GData.mixtureFight.Add(i);
                }

                while (!myLoad.EndOfStream)
                {
                    content = content + myLoad.ReadLine();
                }
                newList = content.Split('/');
                data = new List<string>();
                foreach (string i in newList)
                {
                    data.Add(i);
                }
                Player.outputProgress = data[0].Substring(1);
                Player.variableProgress = data[1].Substring(1);
                Player.inputProgress = data[2].Substring(1);
                Player.conditionProgress = data[3].Substring(1);
                Player.switchProgress = data[4].Substring(1);
                Player.whileProgress = data[5].Substring(1);
                Player.forProgress = data[6].Substring(1);
                Player.arrayProgress = data[7].Substring(1);
                Player.functionProgress = data[8].Substring(1);
                Player.classProgress = data[9].Substring(1);
                Player.objectProgress = data[10].Substring(1);
                Player.mixtureProgress = data[11].Substring(1);

                if (!data[12].Equals("|"))
                {
                    string[] newData = data[12].Substring(1).Split('|');
                    foreach (string i in newData)
                    {
                        Player.stuffs.Add(i);
                    }
                }

                Camera.main.transform.position = new Vector3(Player.cameraM.x, Player.cameraM.y, Player.cameraM.z);
                GameObject.FindGameObjectWithTag("Player").gameObject.transform.position = new Vector3(Player.playerM.x, Player.playerM.y, Player.playerM.z);
                if (Player.aWeapon != null){
                    GameObject.FindGameObjectWithTag("Status").GetComponent<PlayerStatus>().swordL.ClearOptions();
                    GameObject.FindGameObjectWithTag("Status").GetComponent<PlayerStatus>().swordL.AddOptions(Player.aWeapon);
                }
                    
                if (Player.dWeapon != null){
                    GameObject.FindGameObjectWithTag("Status").GetComponent<PlayerStatus>().sheildL.ClearOptions();
                    GameObject.FindGameObjectWithTag("Status").GetComponent<PlayerStatus>().sheildL.AddOptions(Player.dWeapon);
                }
                    

                if (Player.stuffs != null)
                {
                    foreach (string stuff in Player.stuffs)
                    {
                        GameObject.Find(stuff).SetActive(false);
                    }
                }
            }
        }
    }

    public void LoadingGameDead(){
        this.gameObject.SetActive(false);
        if (File.Exists("save.txt"))
            LoadingGame();
        else
            SceneManager.LoadScene(3);
    }
}
