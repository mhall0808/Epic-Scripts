using UnityEngine;
using System.Collections;

public class Alexis : BasePlayer {

	// Use this for initialization
	public Alexis () {


		this.playerName    = "Alexis";
		this.playerClass   = "Soldier";
		this.playerProfile = "Images/Cloud";
		this.playerLevel   = 1;
		this.strength      = 35;
		this.intelligence  = 15;
		this.speed         = 15;
		this.spirit        = 10;
		this.defense       = 35;
		this.hitPoints     = 150;
		this.currentHP     = this.hitPoints;
		this.magicPoints   = 50;
		this.currentMP     = this.magicPoints;

		weapon    = new IronSword ();
		armor     = new LeatherArmor ();
		accessory = new HPRing ();

		UpdatePlayer ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
