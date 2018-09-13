using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlVida : MonoBehaviour {

	public GameObject[] vidas;
	int cuentavidas=2;
	public static ControlVida instance;
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

}//fin de la clase
