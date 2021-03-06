﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial_movimiento : MonoBehaviour {

	public float velocidadMovimiento=0f;
	public float velocidadRotacion=50f;
	public Vector3 nuevaDireccion;
	Rigidbody2D mirigidbody;
	// Use this for initialization
	void Start () {
		nuevaDireccion = transform.right;
		mirigidbody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward,- velocidadRotacion * Input.GetAxis("Horizontal")* Time.deltaTime);
	}// fin del update

	void FixedUpdate(){
		// movimiento no kinematico, afectado por fisicas
		velocidadMovimiento = Mathf.Clamp (velocidadMovimiento,0,10);
		if (Input.GetKey (KeyCode.UpArrow)) {
			mirigidbody.AddForce (transform.up * velocidadMovimiento);
		}// fin del if
		velocidadMovimiento = Mathf.Clamp (velocidadMovimiento,0,5);
	}// fin de fixdUpdate
}
