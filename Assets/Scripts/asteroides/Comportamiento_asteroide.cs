using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportamiento_asteroide : MonoBehaviour {

	//int direccionx=1,direcciony=1,direccionz=1;

	Rigidbody2D rigid;
	public float velocidadRotacion=1f;
	float velocidadMovimiento=5f;
	Vector3 direccion;
	int cantidadAsteroides;
	int limiteCantidadAsteroides;
	float tiempoCreacionAsteroides=2f;
	void Start () {
		direccion_asteroide();
		velocidad_asteroide ();
		rotacion_asteroide ();
		rigid = GetComponent<Rigidbody2D>();
		Debug.Log ("asteroides moviendoce"+direccion * velocidadMovimiento);
		rigid.AddRelativeForce (direccion * velocidadMovimiento,ForceMode2D.Force);
		velocidadMovimiento = Mathf.Clamp (velocidadMovimiento,0,5);

	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward,velocidadRotacion*Time.deltaTime);
	}
		
	 void direccion_asteroide(){
		int direccionNumero = Random.Range (1,5);
		int x=Random.Range (-5,5), y = Random.Range (-5, 5);
		direccion = new Vector3 (x,y,0f);

	}// fin de direccion

	 void velocidad_asteroide(){
		velocidadMovimiento = Random.Range (20,100);
	}// fin de direccion

	void rotacion_asteroide(){
		velocidadRotacion = Random.Range (50,200);
	}// fin de direccion

	void FixedUpdate(){
		
	}// fin de fixdUpdate
}
