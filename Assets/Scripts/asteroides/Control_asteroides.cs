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
	// Use this for initialization
	void Start () {
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
			x =	Random.Range (player.transform.position.x, player.transform.position.x+14);	
			y =	Random.Range (player.transform.position.y, player.transform.position.y+14);
			break;
		case 2:
			x=	Random.Range (player.transform.position.x, player.transform.position.x-14);	
			y=	Random.Range (player.transform.position.y, player.transform.position.x-14);
			break;
		case 3:
			x=	Random.Range (player.transform.position.x, player.transform.position.x+14);	
			y=	Random.Range (player.transform.position.y, player.transform.position.y-14);
			break;
		case 4:
			x=	Random.Range (player.transform.position.x, player.transform.position.x-14);	
			y=	Random.Range (player.transform.position.y, player.transform.position.y+14);
			break;
		}// fin de switch

		return new Vector3(x,y,0);
	}//

	void GenerarAsterorides(){
		for(int i=0;i<40;i++){
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
