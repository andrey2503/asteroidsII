using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlVida : MonoBehaviour {

	public GameObject[] vidas;
	int cuentavidas=2;
	public static ControlVida instance;
	public GameObject player;
	// Use this for initialization

	void Awake(){
		if(instance==null){
			instance = this;
		}else{
			Destroy (this.gameObject);
		}
	}// fin de awake

	public void disminuirVida(){
		vidas [cuentavidas].SetActive (false);
		cuentavidas--;
	}// fin de dismiuirVida

	public void reiniciarPersonaje(){
		StartCoroutine (crearPersonaje());
	}

	IEnumerator crearPersonaje(){
		yield return new WaitForSeconds (2f);
		Instantiate (player,player.transform.position,player.transform.rotation);
	}

}//fin de la clase
