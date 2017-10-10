using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniformMotion2 : MonoBehaviour {
	public float vx, vy, m;

	void FixedUpdate () {
		this.transform.Translate(vx * Time.deltaTime, vy * Time.deltaTime, 0f);
	}
}
