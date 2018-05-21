using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class corazon : MonoBehaviour {

	//public Sprite cora03;
	private Bird bird;
	public Sprite cora03;
	public Sprite cora02;
	public Sprite cora01;
	public Sprite cora00;
	private int cora;
	// Use this for initialization
	void Start () {
		bird = FindObjectOfType<Bird> ();
		//bird = GetComponent<Bird>();
		cora = bird.getLife ();
	}
	
	// Update is called once per frame
	void Update () {
		cora = bird.getLife ();
		switch (cora) {
		case 2:
			//this.GetComponent<SpriteRenderer> ().sprite = cora02; 
			this.transform.GetComponent<UnityEngine.UI.Image> ().sprite = cora02;
			break;

		case 1:
			//this.GetComponent<SpriteRenderer> ().sprite = cora01; 
			this.transform.GetComponent<UnityEngine.UI.Image> ().sprite = cora01;
			break;

		case 0:
			//this.GetComponent<SpriteRenderer> ().sprite = cora00; 
			this.transform.GetComponent<UnityEngine.UI.Image> ().sprite = cora00;
			break;

		/*default:
			this.GetComponent<SpriteRenderer> ().sprite = cora03; 
			break;*/
		
		}
	}

}
