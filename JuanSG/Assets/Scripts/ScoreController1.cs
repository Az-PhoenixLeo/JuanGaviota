using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;


public class PlayerScore{
	public string playerName;
	public int playerScore;

	public PlayerScore(string playerName, int playerScore){
		this.playerName = playerName;
		this.playerScore = playerScore;
	}

	public string GetFormat()
	{
		return playerName + "~S~" + playerScore;
	}
}


public class ScoreController1 : MonoBehaviour {

	public int scoreCount;
	private string score;

	[Header("GUARDA SCORE")]
	public InputField inputName;
	public InputField inputScore;
	//public Text inputScore;

	[Header("PUNTAJES")]
	public GameObject scoreObject;
	public GameObject scoreRoot;
	public Text textName, textScore;

	private GameController gc;

	static ScoreController1 scoreBoard;
	static string separator = "~S~";
	// Use this for initialization
	void Start () {
		scoreBoard = this;
		StartCoroutine (CoShowScore ());
		gc = FindObjectOfType<GameController> ();
	}
		

	void Update(){
		if (Input.GetKeyDown (KeyCode.S)) {

			SaveScore ("S", 0);
		}

		if (Input.GetKeyDown (KeyCode.P)) {
			List<PlayerScore> playerScores = GetScore ();
			foreach (PlayerScore p in playerScores) 
			{
				print(p.playerName + "   " + p.playerScore);
			}

		}
	}


	public void SaveScoreNow(){
		SaveScore (inputName.text, int.Parse(inputScore.text));
		print(gc.getScore());
		//score = gc.getScore ();
		//SaveScore (inputName.text, gc.getScore());
	}

	public void ShowScore(){
		StartCoroutine (CoShowScore ());
	}

	IEnumerator CoShowScore()
	{
		while (scoreRoot.transform.childCount > 0) {
			Destroy (scoreRoot.transform.GetChild (0).gameObject);
			yield return null;
		}
		List<PlayerScore> playerScore = GetScore ();
		foreach (PlayerScore score in playerScore) {
			textName.text = score.playerName;
			textScore.text = score.playerScore.ToString();

			GameObject instantiatedScore = Instantiate (scoreObject);
			instantiatedScore.SetActive (true);


			instantiatedScore.transform.SetParent (scoreRoot.transform);
			instantiatedScore.gameObject.transform.localScale = new Vector3 (1f, 1f, 1f);


		}
	}

	void SaveScore(string name, int score){	
		//print (score);
		List<PlayerScore> playerScores = new List<PlayerScore> ();
		for (int i = 0; i < scoreBoard.scoreCount; i++) {
			if (PlayerPrefs.HasKey ("Score" + i)) {
				string[] scoreformat = PlayerPrefs.GetString ("Score" + i).Split (new string[] { separator }, System.StringSplitOptions.RemoveEmptyEntries);
				playerScores.Add (new PlayerScore (scoreformat [0], int.Parse (scoreformat [1])));
			} else {
				break;
			}
		}

		if (playerScores.Count < 1) {
			PlayerPrefs.SetString ("Score0", name + separator + score);
			return;
		}

		playerScores.Add (new PlayerScore (name, score));
		playerScores = playerScores.OrderByDescending (o => o.playerScore).ToList ();

		for (int i = 0; i < scoreBoard.scoreCount; i++) {
			if (i >= playerScores.Count) { break; }
			PlayerPrefs.SetString ("Score" + i, playerScores [i].GetFormat ());
		}

	}

	public List<PlayerScore> GetScore(){
		List<PlayerScore> playerScores = new List<PlayerScore> ();
		for (int i = 0; i < scoreBoard.scoreCount; i++) 
		{
			if (PlayerPrefs.HasKey ("Score" + i)) {
				string[] scoreformat = PlayerPrefs.GetString ("Score" + i).Split (new string[] { separator }, System.StringSplitOptions.RemoveEmptyEntries);
				playerScores.Add (new PlayerScore (scoreformat [0], int.Parse (scoreformat [1])));

			} else 
			{
				break;
			}
		}
		return playerScores;
	}


}
