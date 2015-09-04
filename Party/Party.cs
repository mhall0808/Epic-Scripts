using UnityEngine;
using System.Collections;
using System.Collections.Generic;


	public class Party : MonoBehaviour
	{
	public List<BasePlayer> players;
	public List<BaseEquipment> inventory;


	public Party(){
		players   = new List <BasePlayer> ();
		inventory = new List <BaseEquipment> ();
		
		players.Add (new Alexis());
		players.Add (new Zander ());
		inventory.Add (new IronSword ());
		Debug.Log ("Party Function");
	}


		void Start ()
		{

		}

	}

