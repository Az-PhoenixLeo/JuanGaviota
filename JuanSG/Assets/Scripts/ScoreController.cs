using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour {

	public ScoreController1 scoreBoard;

	void Start () {
		//scoreBoard = FindObjectOfType<ScoreBoard> ();
	}
	private void Awake(){
		//scoreBoard = FindObjectOfType<ScoreBoard> ();
		scoreBoard.ShowScore ();
	}

}
