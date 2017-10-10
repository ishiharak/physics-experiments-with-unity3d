using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour {
	public float k, m;
	float v;

	void Start () {
		v = 0f;
	}

	void Update () {
		float x = this.transform.position.x;
		float a = k * x / m;
		v = v + a * Time.deltaTime;
		x = x + v * Time.deltaTime;
		this.transform.position = new Vector3(x, 0f, 0f);
	}
}
