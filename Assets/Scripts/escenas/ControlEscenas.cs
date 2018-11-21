using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControlEscenas : MonoBehaviour {
	public static ControlEscenas instance;
	void Awake(){
		if(ControlEscenas.instance==null){
			ControlEscenas.instance = this;
		}else{
			Destroy (this.gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void IniciarMenu(){
		GameControl.instance.guardarPuntaje ();
		Destroy (GameControl.instance.gameObject);
		SceneManager.LoadScene ("Menu");	
	}// iniciar menu

	public void IniciarJuego(){
		SceneManager.LoadScene ("Story");	
	}//

}
