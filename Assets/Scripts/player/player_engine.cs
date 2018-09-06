using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_engine : MonoBehaviour {
	public GameObject player;
	public GameObject up;
	public GameObject down;
	public static player_engine instance;
	public float mover=0.50f;
	public float velocidadRotacion=0.05f;
	// Use this for initialization
	void Awake(){
		if(player_engine.instance == null){
			player_engine.instance = this;
		}else{
			Destroy (this.gameObject);
		}// else
	}// fin del Awake
	void Start () {
		
	}

	public float getVelocityPostY (){
		return  player.GetComponent<Rigidbody2D> ().velocity.y;
	}

	public void moverUP(){
		player.transform.position = Vector3.Lerp(player.transform.position, up.transform.position, mover);
	}// FIN DE MOVERuP


	public void girarDerecha(){
		player.transform.Rotate(Vector3.right * Time.deltaTime * velocidadRotacion);
	}// fin de girar derecha

	public void girarIzquierda(){
		player.transform.Rotate(Vector3.left * Time.deltaTime * velocidadRotacion);
	}

}
