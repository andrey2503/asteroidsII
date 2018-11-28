using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision_bala : MonoBehaviour {
	public int tipoAsteroide;
	public GameObject asteroidePequeno;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D meta){
		if(meta.gameObject.tag=="bala" && tipoAsteroide==1){
			Destroy (meta.gameObject);
			Control_asteroides.instance.subirNumeroAsteroidesGrandes ();
			Control_puntos.instance.sumarPuntos (20);
			Instantiate (asteroidePequeno,meta.gameObject.transform.position,meta.gameObject.transform.rotation);
			Instantiate (asteroidePequeno,meta.gameObject.transform.position,meta.gameObject.transform.rotation);
			ControlSonido.instance.sonidoExplosionAsteroide (1f);
			Destroy (this.gameObject);			
		}

		if(meta.gameObject.tag=="bala" && tipoAsteroide==2){
			Destroy (meta.gameObject);
			Control_asteroides.instance.subirNumeroAsteroidesMedianos ();
			Control_puntos.instance.sumarPuntos (50);
			Instantiate (asteroidePequeno,meta.gameObject.transform.position,meta.gameObject.transform.rotation);
			ControlSonido.instance.sonidoExplosionAsteroide (0.50f);
			Destroy (this.gameObject);			
		}

		if(meta.gameObject.tag=="bala" && tipoAsteroide==3){
			Control_puntos.instance.sumarPuntos (100);
			ControlSonido.instance.sonidoExplosionAsteroide (0.20f);
			Destroy (this.gameObject);			
		}
		if(meta.gameObject.tag=="Player"){
			if (tipoAsteroide == 1) {
				Control_asteroides.instance.subirNumeroAsteroidesGrandes ();

			} else if(tipoAsteroide==2) {
				Control_asteroides.instance.subirNumeroAsteroidesMedianos ();
			}
			ControlVida.instance.disminuirVida ();
			Destroy (meta.gameObject);
			ControlSonido.instance.sonidoMuerteJugador ();
			Destroy (this.gameObject);
		}
	}// fin de onColisionEnter

}
