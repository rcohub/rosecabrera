﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour {

	public void ResetScene () {

		Scene scene = SceneManager.GetActiveScene();
		ScoreBoardDisplay.Score = 0;
		SceneManager.LoadScene(scene.name);

	}
}
