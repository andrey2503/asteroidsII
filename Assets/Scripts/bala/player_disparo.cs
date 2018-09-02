using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_disparo : MonoBehaviour {

	public static player_disparo instance;
	public GameObject bala;
	public GameObject salidaBala;
	public GameObject player;
	void Awake(){
		if(player_disparo.instance == null){
			player_disparo.instance = this;
		}else{
			Destroy (this.gameObject);
		}// else
	}// fin del Awake
	// Use this for initialization
	public void disparar(){
		GameObject disparo = Instantiate (bala,salidaBala.transform.position,player.transform.rotation);
		disparo.GetComponent<Rigidbody> ().AddRelativeForce (new Vector2(0,3),ForceMode.VelocityChange);
		StartCoroutine (destruirBala(disparo));
	}// fin de disparar

	IEnumerator destruirBala(GameObject bala){
		yield return  new WaitForSeconds(1f);
		Destroy (bala);
	}

	

}
