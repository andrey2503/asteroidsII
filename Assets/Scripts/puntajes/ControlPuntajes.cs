using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Text;
using System;

public class ControlPuntajes : MonoBehaviour {

	string url="http://localhost:8000";
	JsonScore objetos;
	void Awake(){
		DontDestroyOnLoad (this.gameObject);
	}// fin de Awake
	// Use this for initialization
	void Start () {
		
	}
	

	IEnumerator savedScore(string nombre,string puntos){
		WWWForm form = new WWWForm();
		form.AddField ("nombre",nombre);
		form.AddField ("puntos",puntos);
		UnityWebRequest www = UnityWebRequest.Post(url+"/addScore", form);
		//www.SetRequestHeader ("Content-Type","application/json");
		yield return www.Send();
		if(www.isNetworkError) {
			Debug.Log(www.error);
		}
		else {
			Debug.Log("Form upload complete!");
		}
	}// fin de guardar puntaje

	IEnumerator checkIfScoreIsBestTen(int puntos){
		UnityWebRequest www = UnityWebRequest.Get(this.url+"/gettenbestscore/"+puntos);
		yield return www.SendWebRequest();
		if(www.isNetworkError) {
			Debug.Log(www.error);
		}
		else {
			Debug.Log(www.downloadHandler.text);
			//objetos = JsonUtility.FromJson<JsonScore> (www.downloadHandler.text);
			//Debug.Log (objetos);
			Debug.Log("datos!");
		}
	}// fin de guardar puntaje

	public void eventoBoton(){
		StartCoroutine (savedScore(Control_puntos.instance.nombredelJugador(),Control_puntos.instance.getPuntosFinales()+"" ));
		//Debug.Log ("nombre "+ Control_puntos.instance.nombredelJugador() +" puntos"+Control_puntos.instance.getPuntosFinales());	
	}//

	public void checkScore(){
		StartCoroutine (checkIfScoreIsBestTen(Control_puntos.instance.getPuntosFinales()));
	}// end to checkscore
		

}

[Serializable]
public class JsonScore
{
	public int id;
	public string nombre;
	public string puntos;
}

