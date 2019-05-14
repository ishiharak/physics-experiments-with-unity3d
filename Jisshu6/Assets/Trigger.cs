using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
	
	void Update () {
		this.transform.Translate(0f, -1f * Time.deltaTime, 0f);
	}

	//void ??? () {
	//	print("Hit");
	//}
}
