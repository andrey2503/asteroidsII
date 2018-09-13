using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapAroundRoomAsteroids : MonoBehaviour {

	// Use this for initialization
	public float limiteHorizontal;
	public float limiteVertical;
	void Start () {
		limiteHorizontal=WrapAroundRoom.instance.getLimiteHorizontal ();
		limiteVertical = WrapAroundRoom.instance.getLimiteVertical ();
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
	}
}
