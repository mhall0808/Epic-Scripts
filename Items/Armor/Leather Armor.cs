using UnityEngine;
using System.Collections;

public class LeatherArmor : BaseArmor {

	// Use this for initialization
	void Start () {

		this.itemName        = "Leather Armor";
		this.itemDescription = "Light weight and maneuverable, this armor provides basic care to the DIY warrior.";
		this.canSell         = true;
		
		this.strength        = 0;
		this.intelligence    = 0;
		this.speed           = 0;
		this.spirit          = 0;
		this.defense         = 10;
		this.hitPoints       = 0;
		this.magicPoints     = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
