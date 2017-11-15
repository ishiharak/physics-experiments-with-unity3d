using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorOperation : MonoBehaviour {
	Vector3 a, b;

	void Start () {
		a = new Vector3(1,2,3);
		b = new Vector3(4,5,6);
		Debug.Log(a+b);
	}
	
	void Update () {

	}
}
