using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateFPS : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Debug.Log(Time.time);
	}
}
