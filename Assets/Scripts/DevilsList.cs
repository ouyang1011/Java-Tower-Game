// This script provides a way to create a devil and get all the data of it
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class about data of all types of devils
public class DevilsList{
	private Dictionary<string, DevilStatus> devilsList;

	// Adding all types of devils to Dictionary devilsList
	public DevilsList(){
		devilsList = new Dictionary<string, DevilStatus>();

		devilsList.Add("Zombie", Zombie());
		devilsList.Add("Ghost", Ghost());
		devilsList.Add("Vampire", Vampire());
		devilsList.Add("Fanatic", Fanatic());
		devilsList.Add("Bandit", Bandit());
		devilsList.Add("Asura", Asura());
		devilsList.Add("Behemoth", Behemoth());
		devilsList.Add("Death", Death());
		devilsList.Add("Captain", Captain());
		devilsList.Add("Demon", Demon());
		devilsList.Add("Darklod", Darklod());
	}

	// Get a devil's details
	public DevilStatus GetDevil(string n){
		if(devilsList.ContainsKey(n))
			return devilsList[n];
		else
			return new DevilStatus(0,0,0,0,"");
	}

	// Zombie's data
	DevilStatus Zombie(){
		return new DevilStatus(50,10,5,20,"Zombie");
	}

	// Ghost's data
	DevilStatus Ghost(){
		return new DevilStatus(200,80,50,50,"Ghost");
	}

	// Vampire's data
	DevilStatus Vampire(){
		return new DevilStatus(300,100,90,100,"Vampire");
	}

	// Fanatic's data
	DevilStatus Fanatic(){
		return new DevilStatus(400,120,60,120,"Fanatic");
	}

	// Bandit's data
	DevilStatus Bandit(){
		return new DevilStatus(500,150,100,200,"Bandit");
	}

	// Asura' data; Samll boss
	DevilStatus Asura(){
		return new DevilStatus(1000,300,180,500,"Asura");
	}

	// Behemoth's data
	DevilStatus Behemoth(){
		return new DevilStatus(650,180,140,300,"Behemoth");
	}

	// Death' data; Small boss
	DevilStatus Death(){
		return new DevilStatus(2500,300,250,800,"Death");
	}

	// Captain's data
	DevilStatus Captain(){
		return new DevilStatus(800,210,200,400,"Captain");
	}

	// Demon's data
	DevilStatus Demon(){
		return new DevilStatus(900,280,190,450,"Demon");
	}

	// Darklod's data; Last boss
	DevilStatus Darklod(){
		return new DevilStatus(50,10,5,20,"Darklod");
	}
}
