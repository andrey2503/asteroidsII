using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_inputs : MonoBehaviour {
	
	public static player_inputs instance;
	void Awake(){
		if(player_inputs.instance == null){
			player_inputs.instance = this;
		}else{
			Destroy (this.gameObject);
		}// else
	}// fin del Awake
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void FixedUpdate () {
		float moverUp = Input.GetAxis ("Vertical");
		if(moverUp > 0){
			//Debug.Log (moverUp);
			Debug.Log ("se esta presionado arriba");
			player_engine.instance.moverUP ();

		}else if(moverUp < 0){
			
		}
		float mover = Input.GetAxis ("Horizontal");
		if (mover > 0) {
			player_engine.instance.girarDerecha ();
			//mover a la derecha
		} else if (mover < 0) {
			player_engine.instance.girarIzquierda ();
			//mover a la izquierda
		}// fin de if izquierda Derecha

		if(Input.GetKeyUp("space")){
			player_disparo.instance.disparar();
		}

	}// fin de fixedupdate
}
