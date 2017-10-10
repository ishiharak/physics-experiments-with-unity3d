using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour {
	float rot_x, rot_y;
	// Use this for initialization
	void Start () {
		rot_x = 0;
		rot_y = 0;
	}

	// Update is called once per frame
	void FixedUpdate () {
		rot_x = rot_x + Mathf.PI * 2f * Time.deltaTime;
		rot_y = rot_y + Mathf.PI * 2f * Time.deltaTime;
		this.transform.position = new Vector3(10f*Mathf.Sin(rot_x), 10f*Mathf.Cos(rot_y), 0f);
	}
}
