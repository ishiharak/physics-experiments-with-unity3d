using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchEnabler : MonoBehaviour {
	
	void Start () {
		Invoke("EnableCollider", 5.0f);
	}

	void EnableCollider() {
		this.GetComponent<Collider>().enabled = true;
	}
}
