using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Text;

public class ControlPuntajes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (savedScore());
	}
	

	IEnumerator savedScore(){
		WWWForm form = new WWWForm();
		form.AddField ("nombre","andreyUnity");
		form.AddField ("puntos","9934");
		UnityWebRequest www = UnityWebRequest.Post("http://localhost:8000/addScore", form);
		//www.SetRequestHeader ("Content-Type","application/json");
		yield return www.Send();
		if(www.isNetworkError) {
			Debug.Log(www.error);
		}
		else {
			Debug.Log("Form upload complete!");
		}
	}// fin de guardar puntaje

}
