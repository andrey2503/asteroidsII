using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_inputs : MonoBehaviour {
	
	public static player_inputs instance;
	public float velocidadRotacion=50f;
	//public float velocidadMovimiento=0f;
	Rigidbody2D mirigidbody;
	public Vector3 nuevaDireccion;
	void Awake(){
		if(player_inputs.instance == null){
			player_inputs.instance = this;
		}else{
			Destroy (this.gameObject);
		}// else
	}// fin del Awake
	// Use this for initialization
	void Start () {
		nuevaDireccion = transform.right;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward,- velocidadRotacion * Input.GetAxis("Horizontal")* Time.deltaTime);
	}

	void FixedUpdate(){
		// movimiento no kinematico, afectado por fisicas
		//velocidadMovimiento = Mathf.Clamp (velocidadMovimiento,0,10);
		if (Input.GetKey (KeyCode.UpArrow)) {
			//mirigidbody.AddForce (transform.up * velocidadMovimiento);
			player_engine.instance.moverUP();
		}// fin del if
		if(Input.GetKeyUp(KeyCode.DownArrow)){
			player_engine.instance.hiperespacio ();
		}//
		//velocidadMovimiento = Mathf.Clamp (velocidadMovimiento,0,5);
		if(Input.GetKeyUp("space")){
			player_disparo.instance.disparar();
		}
		if(Input.GetKeyDown("space")){
			player_disparo.instance.disparoCero();
		}
		if(Input.GetKeyDown(KeyCode.Z)){
			player_disparo.instance.disparoCero();
		}
		if(Input.GetKeyUp(KeyCode.Z)){
			player_disparo.instance.disparar();
		}
	}// fin de fixdUpdate

}
