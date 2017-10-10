using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountSpaces : MonoBehaviour {
	int number;
	// Use this for initialization
	void Start () {
		number = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			//???
			Debug.Log(number);
		}
	}
}
