using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateGravity : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void FixedUpdate () {
		Debug.Log(Time.time);
		Debug.Log(this.transform.position.y);
	}
}
