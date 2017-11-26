using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse3 : MonoBehaviour {
	public float e;
	public bool isLocked = false;

	void OnTriggerEnter(Collider other) {
        Debug.Log("AAAAA");
		if (isLocked == false) {
            Vector3 v1 = this.GetComponent<FreeFall3>().v;
            Vector3 v2 = other.GetComponent<FreeFall3>().v;
            float m1 = this.GetComponent<FreeFall3>().m;
            float m2 = other.GetComponent<FreeFall3>().m;
            Vector3 v1dash = ((m1 - e * m2) * v1 + (m2 + e * m2) * v2) / (m1 + m2);
            Vector3 v2dash = ((m1 + e * m1) * v1 + (m2 - e * m1) * v2) / (m1 + m2);
            this.GetComponent<FreeFall3>().v = v1dash;
            other.GetComponent<FreeFall3>().v = v2dash;
			other.GetComponent<Impulse3>().isLocked = true;
        }
	}

    void OnTriggerExit(Collider other) {
        other.GetComponent<Impulse3>().isLocked = false;
        //this.GetComponent<FreeFall3>().g = Vector3.zero;
    }
}
