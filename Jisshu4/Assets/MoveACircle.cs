using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveACircle : MonoBehaviour {
	float x, y;
	// Use this for initialization
	void Start () {
		x = 0f;
		y = 90f * Mathf.Deg2Rad;
	}

	// Update is called once per frame
	void Update () {
		x = x + 360f * Mathf.Deg2Rad * Time.deltaTime;
		y = y + 360f * Mathf.Deg2Rad * Time.deltaTime;
		this.transform.position = new Vector3(5f * Mathf.Sin(x), 5f * Mathf.Sin(y), 0f);
	}
}
