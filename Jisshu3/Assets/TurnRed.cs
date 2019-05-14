using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnRed : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		//if (???) {
			this.GetComponent<MeshRenderer>().material.color = Color.red;
		//}
	}
}
