using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile2 : MonoBehaviour {
	public float v, angle, g;
	float vx, vy;
	bool flag;

	void Start () {
		//vx = ???;
		//vy = ???;
		flag = true;
	}

	void Update () {
		float x = this.transform.position.x;
		float y = this.transform.position.y;
		//x = ???;
		//vy = ???;
		//y = ???;
		this.transform.position = new Vector3(x, y, 0f);
		if (this.transform.position.y < 0 && flag) {
			//Debug.Log (???);
			flag = false;
		}
	}
}
