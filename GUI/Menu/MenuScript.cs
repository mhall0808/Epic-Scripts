using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	public Party party;
	public Text player1Name;
	public Text player1Class;
	public Text player1Level;
	public Text player1HP;
	public Text player1MP;
	public Image player1Profile;

	public Text player2Name;
	public Text player2Class;
	public Text player2Level;
	public Text player2HP;
	public Text player2MP;
	public Image player2Profile;

	public Text player3Name;
	public Text player3Class;
	public Text player3Level;
	public Text player3HP;
	public Text player3MP;
	public Image player3Profile;


	// Use this for initialization
	void Start () {
		player1Profile.sprite = Resources.Load (party.players[0].PlayerProfile, typeof(Sprite)) as Sprite;


		player1Name.text = "Name: " + party.players[0].PlayerName;
		player1Class.text = "Class: " + party.players[0].PlayerClass;
		player1Level.text = "LV: " + party.players[0].PlayerLevel;
		player1HP.text = "HP: " + party.players[0].CurrentHP + "\\" + party.players[0].HitPoints;
		player1MP.text = "MP: " + party.players[0].CurrentMP + "\\" + party.players[0].MagicPoints;

		if (party.players.Count > 1) {
			player2Profile.sprite = Resources.Load (party.players[1].PlayerProfile, typeof(Sprite)) as Sprite;
			player2Name.text = "Name: " + party.players[1].PlayerName;
			player2Class.text = "Class: " + party.players[1].PlayerClass;
			player2Level.text = "LV: " + party.players[1].PlayerLevel;
			player2HP.text = "HP: " + party.players[1].CurrentHP + "\\" + party.players[1].HitPoints;
			player2MP.text = "MP: " + party.players[1].CurrentMP + "\\" + party.players[1].MagicPoints;
		}

		if (party.players.Count > 2) {
			Debug.Log("Arrived here.  WHYYYYY?!?!?!?!");
			player3Profile.sprite = Resources.Load (party.players[2].PlayerProfile, typeof(Sprite)) as Sprite;
			player3Name.text = "Name: " + party.players[2].PlayerName;
			player3Class.text = "Class: " + party.players[2].PlayerClass;
			player3Level.text = "LV: " + party.players[2].PlayerLevel;
			player3HP.text = "HP: " + party.players[2].CurrentHP + "\\" + party.players[2].HitPoints;
			player3MP.text = "MP: " + party.players[2].CurrentMP + "\\" + party.players[2].MagicPoints;
		}

		}

	// Update is called once per frame
	void Update () {
	
	}

	public void ChangeScene (int sceneNumber) {

		Application.LoadLevel (sceneNumber);

	}
}
