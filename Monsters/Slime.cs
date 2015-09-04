using UnityEngine;
using System.Collections;

public class Slime : BasePlayer {

	// Constructor.  A slimy constructor.
	public Slime() {
		this.playerName   = "Slime";
		this.playerClass  = "Monster";
		this.playerProfile = "Images/generic";
		this.playerLevel  = 1;
		this.strength     = 5;
		this.intelligence = 5;
		this.speed        = 5;
		this.spirit       = 10;
		this.defense      = 25;
		this.hitPoints    = 15;
		this.currentHP    = this.hitPoints;
		this.magicPoints  = 5;
		this.currentMP    = this.magicPoints;
	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
