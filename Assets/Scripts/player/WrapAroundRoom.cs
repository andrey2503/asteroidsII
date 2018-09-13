using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapAroundRoom : MonoBehaviour {

	public float limiteHorizontal;
	public float limiteVertical;
	public static WrapAroundRoom instance;
	// Use this for initialization

	void Awake(){
		if(instance==null){
			instance = this;
		}else{
			Destroy (this.gameObject);
		}
	}//fin del awake

	void Start () {
		//limiteHorizontal = 13.32f;
		//limiteVertical = 9.54f;
		limiteHorizontal= Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,0,transform.position.z- Camera.main.transform.position.z)).x;
		limiteVertical = Camera.main.ScreenToWorldPoint(new Vector3(0,Screen.height,transform.position.z- Camera.main.transform.position.z)).y;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x	> limiteHorizontal){
			transform.position = new Vector3 (-limiteHorizontal,transform.position.y,0);
		}
		if(transform.position.x	< -limiteHorizontal){
			transform.position = new Vector3 (limiteHorizontal,transform.position.y,0);
		}
		if(transform.position.y	> limiteVertical){
			transform.position = new Vector3 (transform.position.x,-limiteVertical,0);
		}
		if(transform.position.y	< -limiteVertical){
			transform.position = new Vector3 (transform.position.x,limiteVertical,0);
		}
	}// fin del update

	public float getLimiteHorizontal(){
		return limiteHorizontal;
	}//fin de getLimiteHorizontal
	public float getLimiteVertical(){
		return limiteVertical;
	}//fin de getLimiteVertical

}// fin de la clase
