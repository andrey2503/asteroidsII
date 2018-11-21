using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlHighscore : MonoBehaviour {

	public Text highscore;
	// Use this for initialization
	void Start () {
		highscore.text = GameControl.instance.leerPuntaje() +"";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
