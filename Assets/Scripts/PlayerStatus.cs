// This script displays the status of character and Save, Load, Progress, and Exit buttons in status bars
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Class to display character's status in bars
public class PlayerStatus : MonoBehaviour {
	private Text hp;
	private Text att;
	private Text def;
	private Text exp;
	private Text floorNum;
	public Dropdown swordL;
	public Dropdown sheildL;
	public Image sword;
	public Image sheild;
	public Text swordDetail;
	public Text sheildDetail;
	public Text point;

    // Use this for initialization
    void Start(){
		hp = GameObject.FindGameObjectWithTag ("HP").GetComponent<Text> ();
		att = GameObject.FindGameObjectWithTag ("Attack").GetComponent<Text> ();
		def = GameObject.FindGameObjectWithTag ("Defense").GetComponent<Text> ();
		exp = GameObject.FindGameObjectWithTag ("EXP").GetComponent<Text> ();
		floorNum = GameObject.FindGameObjectWithTag ("Floor").GetComponent<Text> ();

        if (!Player.ifLoad)
        {
            Player.Init();
            Camera.main.transform.position = new Vector3(260, -260, -10f);
            GameObject.FindGameObjectWithTag("Player").gameObject.transform.position = new Vector3(260, -481, 0);
            swordL.AddOptions(Player.aWeapon);
            sheildL.AddOptions(Player.dWeapon);
        }
    }

    // Update is called once per frame
    void Update () {
        if(Player.ifLoad){
            Player.ifLoad = false;
            GameObject.FindGameObjectWithTag("Load").GetComponent<Loading>().LoadingGame();
        }
        // Level up
        if (Player.exp >= Player.maxE && Player.exp != 0) {
			Player.exp -= Player.maxE;
			Player.maxH += Player.maxE;
			Player.maxE += 50;
			Player.attack += Player.maxE / 10;
			Player.defense += Player.maxE / 20;
			Player.health = Player.maxH;
		}

		// Display character's status and caculate totally scores
		point.text = "Total Score: " + Player.point;
		hp.text = "" + Player.health + "/" + Player.maxH;
		att.text = "" + (Player.attack + Player.equipmentAttack);
		def.text = "" + (Player.defense + Player.equipmentDefense);
		exp.text = "" + Player.exp+ "/" + Player.maxE;

		// Display the floor name and number
		floorNum.text = GData.getFloorName() + "\n" + "Floor: " + GData.floorNum + " of 20";

		// Cheat to boost character
        /*if (Input.GetButtonDown ("Boost")) {
			Player.maxH = 9999;
			Player.health = 9999;
			Player.attack = 979;
			Player.defense = 545;
			Player.exp = 0;
			Player.maxE = 0;
		}*/
	}

	// Function to get new equipments
	public void GetWeapon(string type, string weaponName){
		List<string> newWeapon = new List<string> () { weaponName };
		switch (type) {
		// Add new weapon
		case "Sword":
			swordL.AddOptions (newWeapon);
			Player.aWeapon.Add (weaponName);
			break;
		// Add new shield
		case "Shield":
			sheildL.AddOptions (newWeapon);
			Player.dWeapon.Add (weaponName);
			break;
		}
	}

	// Function to change the weapon
	public void ChangeSword(int index){
		if (index == 0) {
			Player.equipmentAttack = 0; 
			sword.sprite = null;
			swordDetail.text = "";
		} else if (index == 1){
			Player.equipmentAttack = 20;
			sword.sprite = Resources.Load<Sprite> ("sword1");
			swordDetail.text = "Attack: + 20";
		}else{
			Player.equipmentAttack = 200;
			sword.sprite = Resources.Load<Sprite> ("sword2");
			swordDetail.text = "Attack: + 200";
		}
	}

	// Function to change the shield
	public void ChangeShield(int index){
		if (index == 0) {
			Player.equipmentDefense = 0; 
			sword.sprite = null;
			sheildDetail.text = "";
		} else if (index == 1){
			Player.equipmentDefense = 0;
			sheild.sprite = Resources.Load<Sprite> ("sheild1");
			sheildDetail.text = "Defense: + 10";
		}else{
			Player.equipmentDefense = 100;
			sheild.sprite = Resources.Load<Sprite> ("sheild2");
			sheildDetail.text = "Defense: + 100";
		}
	}
}
