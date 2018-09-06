using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportamiento_asteroide : MonoBehaviour {

	//int direccionx=1,direcciony=1,direccionz=1;
	int velocidad=1;
	Rigidbody rigid;
	// Use this for initialization
	float movimientospeed,rotationspeed,direccion;
	void Start () {
		movimiento ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(1,1,1) * Time.deltaTime*velocidad, Space.World);
		//transform.Translate (new Vector3(direccionx+direccionx,direcciony+direcciony,direccionz+direccionz));
	}

	void movimiento(){
		rigid = GetComponent<Rigidbody> ();
		direccion = Random.Range (0f, 360f) * Mathf.Deg2Rad;
		movimientospeed = Random.Range (150f, 200f);
		rotationspeed = Random.Range (-180f, 180f);
		Vector2 vectorDir = new Vector2 (Mathf.Cos(direccion),Mathf.Sin(direccion));
		rigid.AddForce (vectorDir*movimientospeed);
		//rigid.AddRelativeForce (vectorDir*movimientospeed,ForceMode.VelocityChange);
		//rigid.AddTorque (rotationspeed);

	}
}
