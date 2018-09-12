using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Control_puntos : MonoBehaviour {

	public Text puntos;
	public int puntoFinales=0000;

	public static Control_puntos instance;
	void Awake(){
		if(instance== null){
			instance = this;
		}else{
			Destroy (this.gameObject);
		}
	}// fin de awake 


	void Start () {
		puntos.text = "0000";
	}

	public void sumarPuntos(int puntosganados){
		puntoFinales+= puntosganados ;
		puntos.text = ""+puntoFinales;
	}// fin de sumar Puntos

}
