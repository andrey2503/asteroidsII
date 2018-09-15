using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlVida : MonoBehaviour {

	public GameObject[] vidas;
	int cuentavidas=2;
	public static ControlVida instance;
	public GameObject player;
	public GameObject gameOver;
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
		if (cuentavidas == -1) {
			/*GameObject[] respawns1 = GameObject.FindGameObjectsWithTag("asteroide1");
			GameObject[] respawns2 = GameObject.FindGameObjectsWithTag("asteroide2");
			GameObject[] respawns3 = GameObject.FindGameObjectsWithTag("asteroide3");
			foreach (GameObject respawn in respawns1)
			{
				Destroy (respawn,1f);
			}
			foreach (GameObject respawn in respawns2)
			{
				Destroy (respawn,1f);
			}
			foreach (GameObject respawn in respawns2)
			{
				Destroy (respawn,1f);
			}
			*/
			StartCoroutine (aparecerGameOver ());
		} else {
			StartCoroutine (crearPersonaje());
		}// din del else
	}// fin de dismiuirVida

	public void reiniciarPersonaje(){
		StartCoroutine (crearPersonaje());
	}

	IEnumerator crearPersonaje(){
		yield return new WaitForSeconds (2f);
		Instantiate (player,player.transform.position,player.transform.rotation);
	}

	IEnumerator aparecerGameOver(){
		yield return new WaitForSeconds (3f);
		gameOver.SetActive (true);
	}

}//fin de la clase
