﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCtrl : MonoBehaviour {
	private loaderScene LoadScene;

	public void GameStart(){
		// crear los datos del juego
		LoadScene = gameObject.AddComponent<loaderScene>();
		// Cambiar para cinematica1
		LoadScene.SetSceneName ("main");
		LoadScene.changeScene ();
	}

	public void ScoreBoard(){
		// crear los datos del juego
		LoadScene = gameObject.AddComponent<loaderScene>();
		// Cambiar para cinematica1
		LoadScene.SetSceneName ("ScoreBoard");
		LoadScene.changeScene ();
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag ("Player")){
			LoadScene.changeScene ();
		}
	}
}
