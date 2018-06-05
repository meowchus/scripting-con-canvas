using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Opcion{SUMA,DIVISION,ORDEN,RAIZ,MULTIPLO}; 

public class Ej05 : MonoBehaviour {
	
	#region Declaración de atributos 

	public Opcion OPCION = Opcion.SUMA;
	public Dropdown opciones;
	public Text respuesta;
	public Slider SlA, SlB, SlC;
	int A, B, C;
	public Text ValorA, ValorB, ValorC;

	#endregion

	public void actualizarValores(){
		ValorA.text = SlA.value.ToString();
		ValorB.text = SlB.value.ToString();
		ValorC.text = SlC.value.ToString();

	}

	public void selecionarOperacion(){
		OPCION=(Opcion)opciones.value;
	}

	public void realizarOperacion(){
		switch (OPCION) {
		case Opcion.SUMA:
			suma ();
			break;
		case Opcion.DIVISION:
			division ();
			break;
		case Opcion.ORDEN:
			orden ();
			break;
		case Opcion.RAIZ:
			raiz ();
			break;
		case Opcion.MULTIPLO:
			multiplo();
			break;
		}

	}

	public void suma(){
		respuesta.text = "Debes crear el metodo suma()";
	}

	public void division(){
		respuesta.text = "Debes crear el metodo division()";
	}

	public void orden(){
		A = (int)SlA.value;
		B = (int)SlB.value;
		C = (int)SlC.value;

		if (A < B) {
			if (B > C) {
				if(A<C){
					respuesta.text = "B > C > A";
				}else if(C==A){
					respuesta.text = "B es la mayor y A y C valen lo mismo.";
				}else{
					respuesta.text = "B > A > C";
				}
			} else if (C > B) {
				respuesta.text = "C > B > A";
			} else {
				respuesta.text="B y C valen lo mismo y son mayores que A.";
			}
		} else if (A > B) {
			if (A > C) {
				if (B > C) {
					respuesta.text = "A > B > C";
				} else if (B == C) {
					respuesta.text = "A es la mayor y B y C valen lo mismo.";
				} else {
					respuesta.text = "A > C > B";
				}
			} else if (A < C) {
				respuesta.text = "C > A > B";
			} else {
				respuesta.text="A y C valen lo mismo y son mayores que B.";
			}
		} else {
			if (B == C) {
				respuesta.text = "A, B y C valen lo mismo.";
			} else if (A > C) {
				respuesta.text = "A y B valen lo mismo y mayores que C.";
			} else {
				respuesta.text= "C es la mayor y A y B valen lo mismo.";
			}
		}
	
	}

	public void raiz(){
		respuesta.text = "Debes crear el metodo raiz()";
	}

	public void multiplo(){
		respuesta.text = "Debes crear el metodo multiplo()";
	}
}
