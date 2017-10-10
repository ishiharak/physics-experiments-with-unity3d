using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kadai1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y < 0f) {
			this.transform.position = new Vector3(0f, 10f, 0f);
		}
	}
}
