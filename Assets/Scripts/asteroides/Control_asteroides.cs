using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_asteroides : MonoBehaviour {
	public GameObject asteroide_pequeno;
	public GameObject asteroide_mediano;
	public GameObject asteroide_grande;
	public GameObject player;
	public float ancho;
	public float alto;
	public GameObject camara;
	public float limiteHorizontal;
	public float limiteVertical;
	// Use this for initialization
	void Start () {
		limiteHorizontal= Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,0,transform.position.z- Camera.main.transform.position.z)).x;
		limiteVertical = Camera.main.ScreenToWorldPoint(new Vector3(0,Screen.height,transform.position.z- Camera.main.transform.position.z)).y;
		GenerarAsterorides ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	Vector3 crearPosicion(){
		int direccion = Random.Range (1,5);
		float x=1f,y=1f;
		Debug.Log (direccion);
		switch (direccion) {
		case 1:
			x =	Random.Range (-limiteHorizontal,limiteHorizontal);	
			y =	-limiteVertical;
			break;
		case 2:
			x =	Random.Range (-limiteHorizontal,limiteHorizontal);	
			y =	limiteVertical;
			break;
		case 3:
			x =	-limiteHorizontal;	
			y = Random.Range (-limiteVertical,limiteVertical);
			break;
		case 4:
			x =	limiteHorizontal;	
			y = Random.Range (-limiteVertical,limiteVertical);
			break;
		}// fin de switch

		return new Vector3(x,y,0);
	}//

	void GenerarAsterorides(){
		for(int i=0;i<10;i++){
			GameObject asteroide = Instantiate(asteroide_pequeno,crearPosicion(),player.transform.rotation);
			Destroy (asteroide,10f);
		}
			StartCoroutine (GenerarAteroides());
	}// fin de generar Asteroides

	IEnumerator GenerarAteroides(){
		yield return new WaitForSeconds (10f);
		GenerarAsterorides ();
	}//

	/*public void disparar(){
		GameObject disparo = Instantiate (bala,salidaBala.transform.position,player.transform.rotation);
		disparo.GetComponent<Rigidbody> ().AddRelativeForce (new Vector2(0,10),ForceMode.VelocityChange);
		Destroy (disparo,1f);
	}// fin de disparar
	*/
}
