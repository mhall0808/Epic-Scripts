using UnityEngine;
using System.Collections;

	public class Zander : BasePlayer
	{
		public Zander ()
		{
		this.playerName   = "Zander";
		this.playerLevel  = 1;
		this.strength     = 15;
		this.intelligence = 35;
		this.speed        = 10;
		this.spirit       = 15;
		this.defense      = 20;
		this.hitPoints    = 100;
		this.currentHP    = this.hitPoints;
		this.magicPoints  = 150;
		this.currentMP    = this.magicPoints;


		}
	}

