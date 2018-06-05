using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
https://www.discoduroderoer.es/ejercicios-propuestos-y-resueltos-en-pseudocodigo/
Ejercicio 01
*/



public class Ej02 : MonoBehaviour {
	public Slider SlA,SlB,SlC;
	public Text pizarra;
	public Text ValorA,ValorB,ValorC;
	int A,B,C;
	int suma,resta,multiplicacion;
	float division;

	public void calculadora(){
		A = (int)SlA.value;
		B = (int)SlB.value;

		suma = A + B;
		resta = A - B;
		multiplicacion = A * B;

		if (B != 0) {
			division = A / B;
			pizarra.text=	"A+B="+suma           + "\n"+
				"A-B="+resta          + "\n"+
				"A*B="+multiplicacion + "\n"+
				"A/B="+division ;	
		} else {
			pizarra.text=	"A+B="+suma           + "\n"+
				"A-B="+resta          + "\n"+
				"A*B="+multiplicacion + "\n"+
				"No es posible dividir entre 0" ;	
		}





	}
	public void actualizarValores(){
		ValorA.text = SlA.value.ToString();
		ValorB.text = SlB.value.ToString();
		ValorC.text = SlC.value.ToString();

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
