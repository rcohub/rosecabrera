using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoardDisplay : MonoBehaviour {

	public static int Score = 0;
	//public GUIStyle customText;
	public int fontSize;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnGUI(){
		//GUI.Label (new Rect (50, 50, 150, 80), "Total Coins: " + Score.ToString(), customText);
		GUIStyle style = GUI.skin.GetStyle("box");
		style.fontSize = fontSize;
		style.alignment = TextAnchor.MiddleLeft;
		style.padding.left = 20;
		style.wordWrap = true;
		GUI.Box (new Rect (50, 50, 250, 80), "Coins Collected: " + Score.ToString() + "\nCoins Remaining: " + GameObject.FindGameObjectsWithTag("Coins").Length);
	}
}
