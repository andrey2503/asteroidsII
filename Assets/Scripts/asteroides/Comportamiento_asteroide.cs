using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportamiento_asteroide : MonoBehaviour {

	//int direccionx=1,direcciony=1,direccionz=1;
	int velocidad=1;
	Rigidbody2D rigid;
	float velocidadRotacion=1f;
	float velocidadMovimiento=5f;
	Vector3 direccion;
	void Start () {
		direccion_asteroide();
		velocidad_asteroide ();
		rotacion_asteroide ();
		rigid = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward,velocidadRotacion *  Time.deltaTime);
		//transform.Translate(new Vector3(1,1,1) * Time.deltaTime*velocidad, Space.World);
		//transform.Translate (new Vector3(direccionx+direccionx,direcciony+direcciony,direccionz+direccionz));
	}
		
	 void direccion_asteroide(){
		int direccionNumero = Random.Range (1,5);
		switch (direccionNumero) {
		case 1:
			direccion = Vector3.up;
			break;
		case 2:
			direccion = Vector3.down;
			break;
		case 3:
			direccion = Vector3.left;
			break;
		case 4:
			direccion = Vector3.right;
			break;
		}// fin de switch
	}// fin de direccion
	 void velocidad_asteroide(){
		velocidadMovimiento = Random.Range (1,5);
	}// fin de direccion

	void rotacion_asteroide(){
		velocidadRotacion = Random.Range (1,5);
	}// fin de direccion

	void FixedUpdate(){
		Debug.Log ("asteroides moviendoce");
		rigid.AddForce (direccion * velocidadMovimiento);
		velocidadMovimiento = Mathf.Clamp (velocidadMovimiento,0,5);
	}// fin de fixdUpdate
}
