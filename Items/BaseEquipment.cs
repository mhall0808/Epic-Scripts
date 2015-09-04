using UnityEngine;
using System.Collections;

public class BaseEquipment
{
	protected string itemName;
	protected string itemDescription;
	protected bool   canSell;

	protected int    strength;
	protected int    intelligence;
	protected int    speed;
	protected int    spirit;
	protected int    defense;
	protected int    hitPoints;
	protected int    magicPoints; 
	
	protected int price;



	public BaseEquipment ()
	{
		this.itemName        = "Default";
		this.itemDescription = "Default description: It is so default-y that the user will never see this.";
		this.canSell         = true;
		this.price           = 0;

		this.strength        = 0;
		this.intelligence    = 0;
		this.speed           = 0;
		this.spirit          = 0;
		this.defense         = 0;
		this.hitPoints       = 0;
		this.magicPoints     = 0;
	}

	public string ItemName {
		get {
			return this.itemName;
		}
		set {
			itemName = value;
		}
	}

	public string ItemDescription {
		get {
			return this.itemDescription;
		}
		set {
			itemDescription = value;
		}
	}

	public bool CanSell {
		get {
			return this.canSell;
		}
		set {
			canSell = value;
		}
	}

	public int Strength {
		get {
			return this.strength;
		}
		set {
			strength = value;
		}
	}

	public int Intelligence {
		get {
			return this.intelligence;
		}
		set {
			intelligence = value;
		}
	}

	public int Speed {
		get {
			return this.speed;
		}
		set {
			speed = value;
		}
	}

	public int Spirit {
		get {
			return this.spirit;
		}
		set {
			spirit = value;
		}
	}

	public int Defense {
		get {
			return this.defense;
		}
		set {
			defense = value;
		}
	}

	public int HitPoints {
		get {
			return this.hitPoints;
		}
		set {
			hitPoints = value;
		}
	}

	public int MagicPoints {
		get {
			return this.magicPoints;
		}
		set {
			magicPoints = value;
		}
	}

	public int Price {
		get {
			return this.price;
		}
		set {
			price = value;
		}
	}
}
