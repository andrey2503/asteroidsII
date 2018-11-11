using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

	public static GameControl instance;
	private int _numerodialogo;
	public int numeroDialogoInicio=1;
	// Use this for initialization
	void Start () {
		if (GameControl.instance == null) {
			GameControl.instance = this;
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (this.gameObject);
		}
	}

	public void iniciarHistoria(){
		
	}//

	public int numerodialogo{
		get{ 
			return _numerodialogo;
		}
		set{ 
			_numerodialogo = value;
		}
	}
}
