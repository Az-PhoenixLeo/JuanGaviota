using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caida : MonoBehaviour {

	public GameObject cometa;
	public GameObject estrella;
	private float addedTimeC;
	private float addedTimeE;
	public float changeRateC;
	public float changeRateE;
	private float equis = 0;
	private Transform puntoLanza;
	// Use this for initialization
	void Start () {
		addedTimeC = 0;
		addedTimeE= 0;	
	}
	
	// Update is called once per frame
	void Update () {
		addedTimeE += Time.deltaTime;
		addedTimeC += Time.deltaTime;
		if (addedTimeC >= changeRateC) {
			equis = Random.Range (-4f, 4f);
			Vector2 pos = new Vector2 (this.gameObject.transform.position.x, this.gameObject.transform.position.y + equis);
			//Vector2 pos = new Vector2 (this.gameObject.transform.localPosition., 0f);
			Instantiate (cometa, pos, Quaternion.identity);
			addedTimeC = 0;
		}
		if (addedTimeE >= changeRateE) {
			equis = Random.Range (-4f, 4f);
			Vector2 pos = new Vector2 (this.gameObject.transform.position.x, this.gameObject.transform.position.y + equis);
			//Vector2 pos = new Vector2 (this.gameObject.transform.localPosition., 0f);
			Instantiate (estrella, pos, Quaternion.identity);
			addedTimeE = 0;
		}
	}
		
}
