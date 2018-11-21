﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

	public static GameControl instance;
	private int _numerodialogo;
	public int numeroDialogoInicio=1;
	public int _vidasActuales = 2;
	public int _puntosActuales=0000;
	public int _puntosLlegar=1000;
	// Use this for initialization
	void Awake () {
		if (GameControl.instance == null) {
			GameControl.instance = this;
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (this.gameObject);
		}
	}

	public void iniciarHistoria(){
		
	}//

	public int numerodialogo{
		get{ 
			return _numerodialogo;
		}
		set{ 
			_numerodialogo = value;
		}
	}

	public int vidasActuales{
		get{ 
			return _vidasActuales;
		}
		set{ 
			_vidasActuales = value;
		}
	}

	public int puntosActuales{
		get{ 
			return _puntosActuales;
		}
		set{ 
			_puntosActuales = value;
		}
	}//punto actuales

	public int puntosLlegar{
		get{ 
			return _puntosLlegar;
		}
		set{ 
			_puntosLlegar = value;
		}
	}//punto actuales

	public void guardarPuntaje(){
		if(PlayerPrefs.GetInt ("Best-score",000) < Control_puntos.instance.puntoFinales){
			PlayerPrefs.SetInt ("Best-score",Control_puntos.instance.puntoFinales);
		}

	}// fin de guardar puntaje

	public int leerPuntaje(){
		return PlayerPrefs.GetInt ("Best-score",000);
	}// fin de leerpuntaje

}// fin de la clase
