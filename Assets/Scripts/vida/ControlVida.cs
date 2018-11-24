using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlVida : MonoBehaviour {

	public GameObject[] vidas;
	int cuentavidas=2;
	public static ControlVida instance;
	public GameObject player;
	public GameObject gameOver;
	public GameObject guardarPuntaje;
	// Use this for initialization

	void Awake(){
		if(instance==null){
			instance = this;
		}else{
			Destroy (this.gameObject);
		}
	}// fin de awake

	void Start(){
		cuentavidas=GameControl.instance.vidasActuales;
		refrescarVidas ();
	}

	public void disminuirVida(){
		vidas [cuentavidas].SetActive (false);
		cuentavidas--;
		GameControl.instance.vidasActuales = cuentavidas;
		if (cuentavidas == -1) {
			StartCoroutine (aparecerGameOver ());
		} else {
			StartCoroutine (crearPersonaje());
		}// din del else
	}// fin de dismiuirVida

	public void refrescarVidas(){
		for(int i=0;i<=cuentavidas;i++){
			vidas [i].SetActive (true);
		}
	}

	public void reiniciarPersonaje(){
		StartCoroutine (crearPersonaje());
	}

	IEnumerator crearPersonaje(){
		yield return new WaitForSeconds (2f);
		Instantiate (player,player.transform.position,player.transform.rotation);
	}

	IEnumerator aparecerGameOver(){
		yield return new WaitForSeconds (3f);
		GameControl.instance.numerodialogo = 0;
		gameOver.SetActive (true);
		GameControl.instance.subirNivelAsteroide1 = 3;
		GameControl.instance.subirNivelAsteroide2 = 5;
		StartCoroutine (aparecerGuardarPuntaje());
	}

	IEnumerator aparecerGuardarPuntaje(){
		yield return new WaitForSeconds (1f);
		guardarPuntaje.SetActive (true);
	}



}//fin de la clase
