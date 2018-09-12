using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision_bala : MonoBehaviour {
	public int tipoAsteroide;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D meta){
		if(meta.gameObject.tag=="bala" && tipoAsteroide==1){
			Control_puntos.instance.sumarPuntos (100);
			Destroy (this.gameObject);			
		}
		if(meta.gameObject.tag=="Player"){
			Debug.Log ("player perdio");
		}
	}// fin de onColisionEnter

}
