using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_disparo : MonoBehaviour {

	public static player_disparo instance;
	public GameObject bala;
	public GameObject salidaBala;
	public GameObject player;
	public float fuerzaBala=10f;
	int balas=0;
	void Awake(){
		if(player_disparo.instance == null){
			player_disparo.instance = this;
		}else{
			Destroy (this.gameObject);
		}// else
	}// fin del Awake
	// Use this for initialization
	public void disparar(){
		if(balas==0){
		balas++;
		GameObject disparo = Instantiate (bala,salidaBala.transform.position,player.transform.rotation);
		disparo.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2(0f,fuerzaBala),ForceMode2D.Impulse);
		Destroy (disparo,1f);
		}
	}// fin de disparar

	public void disparoCero(){
		balas = 0;
	}// fin de disparoCero

}
