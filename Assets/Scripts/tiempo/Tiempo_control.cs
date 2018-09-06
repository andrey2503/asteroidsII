using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Tiempo_control : MonoBehaviour {

	public Text tiempoTexto;
	public float tiempo;
	public static Tiempo_control instance;
	void Awake(){
		if(instance== null){
			instance = this;
		}else{
			Destroy (this.gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		tiempoTexto.text = "0:00";
	}
	
	// Update is called once per frame
	void Update () {
		tiempo += Time.deltaTime;
		int minutos = (int)tiempo / 60;
		int segundos= (int)tiempo%60;
		tiempoTexto.text = minutos.ToString () + ":" + segundos.ToString ().PadLeft (2, '0');
		
	}
}
