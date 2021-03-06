﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Control_puntos : MonoBehaviour {

	public Text puntos;
	public int puntoFinales=0000;
	public Text puntosObtenidos;
	public Text puntosLlegar;
	public static Control_puntos instance;
	void Awake(){
		if(instance== null){
			instance = this;
		}else{
			Destroy (this.gameObject);
		}
	}// fin de awake 


	void Start () {
		puntos.text = GameControl.instance.puntosActuales+"";
		puntoFinales = GameControl.instance.puntosActuales;
		puntosLlegar.text = GameControl.instance.puntosLlegar+"";
	}

	public void setpuntosfinales(int numero){
		puntosObtenidos.text = numero + "";
	}

	public void sumarPuntos(int puntosganados){
		puntoFinales+= puntosganados ;
		puntos.text = ""+puntoFinales;
		GameControl.instance.puntosActuales = puntoFinales;
		puntosObtenidos.text = "" + puntoFinales;
		if(puntoFinales>=GameControl.instance.puntosLlegar){
			puntoFinales = GameControl.instance.puntosLlegar;
			puntos.text = ""+puntoFinales;
			GameControl.instance.puntosActuales=puntoFinales; 
			GameControl.instance.puntosLlegar = GameControl.instance.puntosLlegar + 1000;
			puntosLlegar.text = GameControl.instance.puntosLlegar+"";
			GameControl.instance.numerodialogo = GameControl.instance.numerodialogo+1;
			GameControl.instance.subirNivelAsteroide1 = GameControl.instance.subirNivelAsteroide1+1;
			GameControl.instance.subirNivelAsteroide2 = GameControl.instance.subirNivelAsteroide2+1;
			ControlEscenas.instance.IniciarJuego ();
		}
	}// fin de sumar Puntos

	public int getPuntosFinales(){
		return puntoFinales;
	}// fin de getPuntosFinales
		

}
