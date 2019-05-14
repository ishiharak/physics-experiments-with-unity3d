using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile1 : MonoBehaviour {
	public float v0x, v0y, g;
	float vx, vy;
	bool flag;

	void Start () {
		vx = v0x;
		vy = v0y;
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
			//print(???);
			flag = false;
		}
	}
}
