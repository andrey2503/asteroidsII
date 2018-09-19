using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_asteroides : MonoBehaviour {
	public GameObject asteroide_pequeno;
	public GameObject asteroide_mediano;
	public GameObject asteroide_grande;
	public float ancho;
	public float alto;
	public float limiteHorizontal;
	public float limiteVertical;
	int limiteAsteroidesGrandes=1;
	int limiteAsteroidesMedianos=1;
	bool activar_asteroide = true, activar_asteroideMediado = true;
	// Use this for initialization
	public static Control_asteroides instance;
	void Awake(){
		if (instance == null) {
			instance = this;
		} else {
			Destroy (this.gameObject);
		}
	}

	void Start () {
		limiteHorizontal= Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,0,transform.position.z- Camera.main.transform.position.z)).x;
		limiteVertical = Camera.main.ScreenToWorldPoint(new Vector3(0,Screen.height,transform.position.z- Camera.main.transform.position.z)).y;

	}
	
	// Update is called once per frame
	void Update () {
		if(limiteAsteroidesGrandes <3 && activar_asteroide==true){
			activar_asteroide = false;
			StartCoroutine (GenerarAsteroidesGrandes());
		}
		if(limiteAsteroidesMedianos < 5 && activar_asteroideMediado==true){
			activar_asteroideMediado = false;
			StartCoroutine (GenerarAsteroidesMedianos());
		}
	}

	Vector3 crearPosicion(){
		int direccion = Random.Range (1,5);
		float x=1f,y=1f;
		//Debug.Log (direccion);
		switch (direccion) {
		case 1:
			x =	Random.Range (-limiteHorizontal,limiteHorizontal);	
			y =	-limiteVertical-3;
			break;
		case 2:
			x =	Random.Range (-limiteHorizontal,limiteHorizontal);	
			y =	limiteVertical+3;
			break;
		case 3:
			x =	-limiteHorizontal-3;	
			y = Random.Range (-limiteVertical,limiteVertical);
			break;
		case 4:
			x =	limiteHorizontal+3;	
			y = Random.Range (-limiteVertical,limiteVertical);
			break;
		}// fin de switch

		return new Vector3(x,y,0);
	}//

	void GenerarAsterorides(){
			limiteAsteroidesGrandes++;
			GameObject asteroide = Instantiate(asteroide_grande,crearPosicion(),asteroide_grande.transform.rotation);
	}// fin de generar Asteroides

	void GenerarAsteroidesMedia(){
		GameObject asteroideMediano = Instantiate(asteroide_mediano,crearPosicion(),asteroide_mediano.transform.rotation);
		limiteAsteroidesMedianos++;
	}

	IEnumerator GenerarAsteroidesGrandes(){
		yield return new WaitForSeconds (1f);
		GenerarAsterorides ();
		activar_asteroide = true;
	}//


	IEnumerator GenerarAsteroidesMedianos(){
		yield return new WaitForSeconds (1f);
		GenerarAsteroidesMedia ();
		activar_asteroideMediado = true;
	}//

	public void subirNumeroAsteroidesGrandes(){
		limiteAsteroidesGrandes--;
	}
	public void subirNumeroAsteroidesMedianos(){
		limiteAsteroidesMedianos--;
	}
}
