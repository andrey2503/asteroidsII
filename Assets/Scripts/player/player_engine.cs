using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_engine : MonoBehaviour {
	
	public static player_engine instance;
	Rigidbody2D mirigidbody;
	// Use this for initialization
	public float velocidadMovimiento=0f;
	public float limiteHorizontal;
	public float limiteVertical;
	void Awake(){
		if(player_engine.instance == null){
			player_engine.instance = this;
		}else{
			Destroy (this.gameObject);
		}// else
	}// fin del Awake
	void Start () {
		mirigidbody = GetComponent<Rigidbody2D> ();
		limiteHorizontal= Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,0,transform.position.z- Camera.main.transform.position.z)).x;
		limiteVertical = Camera.main.ScreenToWorldPoint(new Vector3(0,Screen.height,transform.position.z- Camera.main.transform.position.z)).y;

	}



	public void moverUP(){
		mirigidbody.AddForce (transform.up * velocidadMovimiento);
		velocidadMovimiento = Mathf.Clamp (velocidadMovimiento,0,10);
	}// FIN DE MOVERuP

	public void hiperespacio (){
		transform.position = crearPosicion ();
	}// fin de espacio

	Vector3 crearPosicion(){
		int direccion = Random.Range (1,5);
		float x=1f,y=1f;
			x =	Random.Range (-limiteHorizontal,limiteHorizontal);	
			y =	Random.Range (-limiteVertical,limiteVertical);
		return new Vector3(x,y,0);
	}//

}
