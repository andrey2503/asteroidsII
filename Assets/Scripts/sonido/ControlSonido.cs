using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSonido : MonoBehaviour {

	// Use this for initialization
	public static ControlSonido instance;
	public GameObject disparo;
	public GameObject explosionAsteroide;
	public GameObject muerteJugador;
	void Awake(){
		if (ControlSonido.instance == null) {
			ControlSonido.instance = this;
		} else {
			Destroy (this.gameObject);
		}
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void sonidoDisparo(){
		disparo.GetComponent<AudioSource> ().Play ();
	}// fin de disparo sonido

	public void sonidoExplosionAsteroide(float volume){
		explosionAsteroide.GetComponent<AudioSource> ().Stop ();
		explosionAsteroide.GetComponent<AudioSource> ().volume=volume;
		explosionAsteroide.GetComponent<AudioSource> ().Play ();
	}// fin de explosion asteroide

	public void sonidoMuerteJugador(){
		muerteJugador.GetComponent<AudioSource> ().pitch = 0.50f;;
		muerteJugador.GetComponent<AudioSource> ().Play ();
	}
}
