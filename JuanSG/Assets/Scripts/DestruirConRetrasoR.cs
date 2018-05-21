using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirConRetrasoR : MonoBehaviour {
	private float retrazo;
	void Start () {
		retrazo = 1.5f;
		Destroy (gameObject, retrazo);	
	}
}
