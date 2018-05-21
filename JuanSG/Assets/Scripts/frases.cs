using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class frases : MonoBehaviour {

	public Text texto;
	private float addedTime;
	public float changeRate;
	private int i=0;
	private string[] frase = {
		"secreto es dejar de verse a sí mismo como prisionero de un cuerpo limitado, rompe las cadenas de tu pensamiento y romperás tambien las de tu cuerpo.",
		"Las cosas más simples son a menudo las más reales",
		"Tienes la libertad de ser tú mismo y nada se puede poner en tu camino",
		"El cielo no es un lugar y no es un momento. El cielo es ser perfecto",
		"Tenemos que rechazar todo lo que nos limite",
		"Juan gaviota pasó el resto de sus días solo, pero voló mucho más allá de los lejanos acantilados",
		"La única ley es la que gía a la libertad",
		"Para volar a cualquier lugar tan rápido como el pensamiento, debes comenzar sabiendo que ya has llegado",
		"Había llegado a creer que el vuelo de las ideas podía ser tan real como el vuelo del viento y las plumas",
		"El único pesar no era la soledad, sino que los otros se negaran a creer en la gloria que les esperaba",


		//secreto es dejar de verse a sí mismo como prisionero de un cuerpo limitado, rompe las cadenas de tu pensamiento y romperás tambien las de tu cuerpo.
	}; 
	// Use this for initialization
	void Start () {
		texto.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		//print (addedTime);
		addedTime += Time.deltaTime;
		if (addedTime >= changeRate) 
		{
			
			if (i < 10) 
			{
				texto.text = frase [i];
				i++;
			}
			addedTime = 0;
		}

		/*
			foreach (string items in frase) {
				texto.text = items;
				while (addedTime <= changeRate) 
				{
					addedTime += Time.deltaTime;
					addedTime = 0;
				}
			}
		*/
	}
}
