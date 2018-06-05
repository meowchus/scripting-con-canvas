using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
https://www.discoduroderoer.es/ejercicios-propuestos-y-resueltos-en-pseudocodigo/
Ejercicio 01
*/



public class Ej04 : MonoBehaviour {
	public Text respuesta;
	public Slider SlA, SlB, SlC;
	int A,B,C;

	public void comparar(){
		A = (int)SlA.value;
		B = (int)SlB.value;
		C = (int)SlC.value;

		if (A < B) {
			//B es mayor que A. A descartada.
			if (B > C) {
				respuesta.text = "B.";
			} else if (C > B) {
				respuesta.text = "C";
			} else {
				respuesta.text="B y C";
			}
		} else if (A > B) {
			//A es mayor que B. B descartada.
			if (A > C) {
				respuesta.text = "A.";
			} else if (A < C) {
				respuesta.text = "C";
			} else {
				respuesta.text="A y C";
			}
		} else {
			//AyB son iguales
			if (B == C) {
				respuesta.text = "A, B y C";
			} else if (A > C) {
				respuesta.text = "A y B";
			} else {
				respuesta.text= "C";
			}
		}
	
	
	
	
	
	
	}


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
}
