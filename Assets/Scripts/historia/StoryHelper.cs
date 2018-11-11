using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class StoryHelper : MonoBehaviour {
	public Flowchart flchar;
	// Use this for initialization
	void Start () {
		flchar.SetIntegerVariable ("numerodialogo", GameControl.instance.numerodialogo);
		flchar.ExecuteBlock ("Inicio");
	}

	// Update is called once per frame
	void Update () {

	}
}

