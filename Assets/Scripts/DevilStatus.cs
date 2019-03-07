// This script provides a way to create a devil and get all the data of it
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class to assign data to a particular devil
public class DevilStatus {
	private int health;
	private int attack;
	private int defense;
	private int exp;
	private string devilName;

	// Use this for initialization with no arguments
	public DevilStatus(){
		health = 0;
		attack = 0;
		defense = 0;
		exp = 0;
		devilName = "";
	}

	// Use this for initialization with arguments
	public DevilStatus(int h, int a, int d, int e, string n){
		health = h;
		attack = a;
		defense = d;
		exp = e;
		devilName = n;
	}

	// Get health of the devil
	public int GetHealth(){
		return health;
	}

	// Get attack power of the devil
	public int GetAttack(){
		return attack;
	}

	// Get defense power of the devil
	public int GetDefense(){
		return defense;
	}

	// Get experience of the devil
	public int GetExp(){
		return exp;
	}

	// Get the avatar of the devil
	public string GetAvatar(){
		return devilName;
	}
}
