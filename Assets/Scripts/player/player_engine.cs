using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_engine : MonoBehaviour {
	
	public static player_engine instance;
	Rigidbody2D mirigidbody;
	// Use this for initialization
	public float velocidadMovimiento=0f;
	void Awake(){
		if(player_engine.instance == null){
			player_engine.instance = this;
		}else{
			Destroy (this.gameObject);
		}// else
	}// fin del Awake
	void Start () {
		mirigidbody = GetComponent<Rigidbody2D> ();
	}



	public void moverUP(){
		mirigidbody.AddForce (transform.up * velocidadMovimiento);
		velocidadMovimiento = Mathf.Clamp (velocidadMovimiento,0,10);
	}// FIN DE MOVERuP

}
