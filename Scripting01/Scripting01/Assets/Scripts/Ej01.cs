using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
https://www.discoduroderoer.es/ejercicios-propuestos-y-resueltos-en-pseudocodigo/
Ejercicio 01
*/

public class Ej01 : MonoBehaviour {
	public Slider SlA;
	public Slider SlB;
	int A,B,C;
	public Text resultadosA;
	public Text resultadosB;

	public void respuesta(){
		A = (int)SlA.value;
		B = (int)SlB.value;

		C = A;
		A = B;
		B = C;

		resultadosA.text = "A: " + A;
		resultadosB.text = "B: " + B;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
