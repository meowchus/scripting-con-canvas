using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
https://www.discoduroderoer.es/ejercicios-propuestos-y-resueltos-en-pseudocodigo/
Ejercicio 01
*/



public class Ej03 : MonoBehaviour {
	public Text respuesta;
	public Slider SlB, SlA;
	int A,B;

	public void comparar(){
		A = (int)SlA.value;
		B = (int)SlB.value;

		if (A == B) {
			respuesta.text = "A y B son iguales.";
		} else if (A < B) {
			respuesta.text = "B es mayor.";
		} else {
			respuesta.text = "A es mayor.";
		}
	
	
	
	
	
	
	}


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
}
