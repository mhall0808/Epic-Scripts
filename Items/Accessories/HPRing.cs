using UnityEngine;
using System.Collections;

public class HPRing : BaseAccessory {

	// Use this for initialization
	void Start () {
		this.itemName        = "HP Ring";
		this.itemDescription = "This small, red ring holds mystical powers.  Gives +50 HP";
		this.canSell         = true;
		
		this.strength        = 0;
		this.intelligence    = 0;
		this.speed           = 0;
		this.spirit          = 0;
		this.defense         = 0;
		this.hitPoints       = 50;
		this.magicPoints     = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
