using UnityEngine;
using System.Collections;

public class IronSword : BaseWeapon {

	// Use this for initialization
	void Start () {
		this.itemName        = "Iron Sword";
		this.itemDescription = "Sword forged of iron.  Great for stabbing small critters.";
		this.canSell         = true;
		
		this.strength        = 10;
		this.intelligence    = 0;
		this.speed           = 0;
		this.spirit          = 0;
		this.defense         = 0;
		this.hitPoints       = 0;
		this.magicPoints     = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
