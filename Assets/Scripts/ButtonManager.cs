﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public AudioSource SomGame;
	public AudioSource SomCredits;
	public AudioSource SomExit;

	public void NewGameBtn (string NewGameLevel) {
		SceneManager.LoadScene (NewGameLevel);

		SomGame.Play ();
		SceneManager.LoadScene (NewGameLevel);

		SomCredits.Play ();
		SceneManager.LoadScene (NewGameLevel);

		SomExit.Play ();
		SceneManager.LoadScene (NewGameLevel);
	}

	public void ExitGameBtn () {
		Application.Quit ();
	}
}
