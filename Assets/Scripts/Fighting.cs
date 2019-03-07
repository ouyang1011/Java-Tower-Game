// This script displays the character's and devil's status automatically during fighting with animations, caculate the damage of them and give feedback according to result of this fight
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Class to diplay fighting animation and damage
public class Fighting : MonoBehaviour {
	public Text title;
	public Text playerHeal;
	public Text playerAtt;
	public Text playerDef;
	public Text devilHeal;
	public Text devilAtt;
	public Text devilDef;
	public GameObject gameOver;
	public Image devilImage;
	private int devilH;
	private int devilA;
	private int devilD;
	private int devilMH;
	private int devilExp;

	private int playerH;
	private int playerA;
	private int playerD;
	private int increaseA;
	private int increaseD;
	public GameObject question;
	private Animator anim;
	private bool ifFight;

	// Use this for initialization
	void Start(){
		this.gameObject.SetActive (false);
		anim = GetComponent<Animator>();

		playerH = Player.health;
        playerA = Player.attack + Player.equipmentDefense;
        playerD = Player.defense + Player.equipmentDefense;
		
		devilH = 0;
		devilA = 0;
		devilD = 0;
		devilMH = 0;
		devilExp = 0;

		playerHeal.text = "Health: \n   " + playerH + "/" + Player.maxH;
		playerAtt.text = "Attack: \n   " + playerA;
		playerDef.text = "Defence: \n   " + playerD;

		devilHeal.text = "Health: \n   " + devilH + "/50";
		devilAtt.text = "Attack: \n   " + devilA;
		devilDef.text = "Defence: \n   " + devilD;
		title.text = GData.getFloorName() + "\n" + "Floor: " + GData.floorNum + " of 20";

		this.gameObject.SetActive (false);
		ifFight = false;
	}

	// Update is called every frame
	void Update(){
		// Display floor name and number
		title.text = GData.getFloorName() + "\n" + "Floor: " + GData.floorNum + " of 20";

		// Display devil's status
		devilHeal.text = "Health: \n   " + devilH + "/" + devilMH;
		devilAtt.text = "Attack: \n   " + devilA;
        devilDef.text = "Defence: \n   " + devilD;
        playerHeal.text = "Health: \n   " + playerH + "/" + Player.maxH;
		devilHeal.text = "Health: \n   " + devilH + "/" + devilMH;

		// Character turns to attack
		if(anim.GetInteger("State") == 2 && ifFight){
			LoseMHealth();
			ifFight = false;
		// Devil turns to attack
		}else if(anim.GetInteger("State") == 3 && ifFight){
			LosePHealth();
			ifFight = false;
		}

		// Close fight windows when the devil loses
		if (devilH <= 0) {
			anim.SetInteger("State", 0);
			question.gameObject.SetActive (true);
			this.gameObject.SetActive (false);
			Player.exp += devilExp;
			GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement> ().ChangeFeedback ("Your got 50 experiences.");
			if (GData.floorNum == 20)
				SceneManager.LoadScene (4);
		}
		// Game Over when player loses
		if(playerH <= 0){
			anim.SetInteger("State", 0);
			anim.SetBool("isPlayer", true);
			question.gameObject.SetActive (true);
			this.gameObject.SetActive (false);
			gameOver.SetActive(true);
		}
		
	}

	// Change status of Character
	public void Change(bool right){
        playerA = Player.attack + Player.equipmentAttack;
        playerD = Player.defense + Player.equipmentDefense;

        if (right) {
			playerAtt.text = "Attack: \n   " + playerA + "(" + playerA / 10 + " up)";
			playerDef.text = "Defence: \n   " + playerD + "(" + playerD / 5 + " up)";

            playerA = playerA + playerA / 10;
            playerD = playerD + playerD / 5;

        } else {
			playerAtt.text = "Attack: \n   " + playerA;
			playerDef.text = "Defence: \n   " + playerD;
		}
	}

	// Character loses health
	private void LosePHealth(){
		int loseH = devilA - playerD;
		if (loseH > 0)
			playerH = playerH - loseH;
	}

	// The devil loses health
	private void LoseMHealth(){
		int loseH = playerA - devilD;
		if(loseH > 0)
			devilH = devilH - loseH;
	}

	// Set arguments to the devil
	public void SetDevil(int hea, int att, int def, int exp, string name){
		devilH = hea;
		devilD = def;
		devilExp = exp;
		devilMH = hea;
		devilA = att;

		devilImage.sprite = Resources.Load<Sprite>(name);

	}

	// Animation down
	public void Next(int state){
		anim.SetInteger("State", state);
		if(state > 1)
			ifFight = true;
	}
}
