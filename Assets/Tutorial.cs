﻿using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class Tutorial : MonoBehaviour {
	
	void Start () {
		Talk ("To listen the tutorial press the tab key   " +
						"To start the game press the Space key.");
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Q) || Input.GetKeyDown ("left ctrl")) {
			Application.LoadLevel (1);
		}
		if (Input.GetKeyDown(KeyCode.Tab)) {
			Talk ("Welcome to ball juggling. In this game you are an aspiring football player, who will try to keep a ball above the ground as long as possible by kicking it. You will earn more points the less number of times you " +
				"kick in this game. So, try to kick efficiently, and make sure to not let the ball touch the ground when it comes to your right side from your left side.");
			StartCoroutine(WaitTalk(27, "The button to kick is Space Key. The ball will be dropped after the whistle and you can track the location of the ball by the tone it makes. Press Q now to start the game."));
		}
	}

	void Talk (string message) {
		System.Diagnostics.Process.Start ("say", message);
	}
	
	IEnumerator WaitTalk (int sec, string message){
		yield return new WaitForSeconds (sec);
		Talk (message);
	}
}
