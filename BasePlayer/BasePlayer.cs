using UnityEngine;
using System.Collections;
/**
 * BASE PLAYER 
 *   Base player is going to house standard stats and 
 * attributes for each player, to be customized within 
 * each player's class.
 * 
 * Including:
 * 		Player Name  - Name of player
 * 		Player Level - Current level of player
 * 		Player Desc  - Description of said character
 * 		Player Class - Class of player
 * 
 * Stats:
 * 		Strength
 * 		Intelligence
 * 		Speed
 * 		Spirit
 * 		Defense
 * 		HP
 * 		MP
 * 
 * Other stats of note:
 * 		Current HP - Current HP of the player
 * 		Current MP - Current MP of the player
 * 
 * Battle effective stats:
 * 
 * 	These stats will effect battle and will likely not 
 * be displayed to the USER.
 * 
 * 		Fortitude     - Total player defense
 * 		Attack        - Total player damage
 * 		Magic Defense - Total player magic defense
 * 		Magic Attack  - Total player magic attack
 * 
 */
public class BasePlayer 
{
	protected string playerName;
	protected string playerClass;
	protected int    playerLevel;

	protected string playerProfile;

	protected int strength;
	protected int intelligence;
	protected int speed;
	protected int spirit;
	protected int defense;
	protected int hitPoints;
	protected int magicPoints; 

	protected int currentHP;
	protected int currentMP;

	protected int fortitude;
	protected int attack;
	protected int magicDefense;
	protected int magicAttack;

	protected BaseWeapon    weapon;
	protected BaseArmor     armor;
	protected BaseAccessory accessory;

	/** Base player level one stats **/
	public BasePlayer ()
	{
		this.playerName   = "Mr. Default";
		this.playerClass  = "NPC";
		this.playerProfile = "Images/generic";
		this.playerLevel  = 1;
		this.strength     = 25;
		this.intelligence = 25;
		this.speed        = 10;
		this.spirit       = 10;
		this.defense      = 25;
		this.hitPoints    = 100;
		this.currentHP    = this.hitPoints;
		this.magicPoints  = 100;
		this.currentMP    = this.magicPoints;

		this.fortitude = (defense / 2) + (speed / 2);
		this.attack = strength;
		this.magicDefense = spirit;
		this.magicAttack = intelligence;

		weapon    = new BaseWeapon ();
		armor     = new LeatherArmor ();
		accessory = new HPRing ();

		UpdatePlayer ();


	}

	public void UpdatePlayer(){

		this.fortitude = (defense / 2) + (speed / 2);
		this.attack = strength;
		this.magicDefense = spirit;
		this.magicAttack = intelligence;

		int pFort = this.fortitude;
		int pAttack = this.attack;
		int pMDef = this.magicDefense;
		int pMAtk = this.magicAttack;

		pFort += this.weapon.Defense    + this.weapon.Speed;
		pFort += this.armor.Defense     + this.armor.Speed;
		pFort += this.accessory.Defense + this.accessory.Speed;

		pAttack += this.weapon.Strength;
		pAttack += this.armor.Strength;
		pAttack += this.accessory.Strength;

		pMDef += this.weapon.Spirit;
		pMDef += this.armor.Spirit;
		pMDef += this.accessory.Spirit;

		pMAtk += this.weapon.Intelligence;
		pMAtk += this.armor.Intelligence;
		pMAtk += this.accessory.Intelligence;
	}

	public string PlayerName {
		get {
			return this.playerName;
		}
		set {
			playerName = value;
		}
	}

	public string PlayerClass {
		get {
			return this.playerClass;
		}
		set {
			playerClass = value;
		}
	}

	public int PlayerLevel {
		get {
			return this.playerLevel;
		}
		set {
			playerLevel = value;
		}
	}

	public string PlayerProfile {
		get {
			return this.playerProfile;
		}
		set {
			playerProfile = value;
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

	public int CurrentHP {
		get {
			return this.currentHP;
		}
		set {
			currentHP = value;
		}
	}

	public int CurrentMP {
		get {
			return this.currentMP;
		}
		set {
			currentMP = value;
		}
	}

	public int Fortitude {
		get {
			return this.fortitude;
		}
		set {
			fortitude = value;
		}
	}

	public int Attack {
		get {
			return this.attack;
		}
		set {
			attack = value;
		}
	}

	public int MagicDefense {
		get {
			return this.magicDefense;
		}
		set {
			magicDefense = value;
		}
	}

	public int MagicAttack {
		get {
			return this.magicAttack;
		}
		set {
			magicAttack = value;
		}
	}
}

