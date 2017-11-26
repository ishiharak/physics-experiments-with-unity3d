using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeFall3 : MonoBehaviour {
	public Vector3 v, g;
    public float m;

	void FixedUpdate () {
		Vector3 s = this.transform.position;
		v = v + g * Time.deltaTime;
		s = s + v * Time.deltaTime;
		this.transform.position = s;
	}
}
