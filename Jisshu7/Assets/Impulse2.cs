using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse2 : MonoBehaviour {
	public float e;
	public bool isLocked = false;

	void OnTriggerEnter(Collider other) {
		if (isLocked == false) {
            //float v1x = ???;
            //float v1y = ???;
            //float v2x = ???;
            //float v2y = ???;
            //float m1 = ???;
            //float m2 = other.GetComponent<UniformMotion2>().m;
            //float v1xdash = ???;
            //float v1ydash = ???;
            //float v2xdash = ???;
            //float v2ydash = ???;
            //this.GetComponent<UniformMotion2>().vx = v1xdash;
            //this.GetComponent<UniformMotion2>().vy = v1ydash;
            //other.GetComponent<UniformMotion2>().vx = v2xdash;
            //other.GetComponent<UniformMotion2>().vy = v2ydash;
			other.GetComponent<Impulse2>().isLocked = true;
        }
	}

    void OnTriggerExit(Collider other) {
        other.GetComponent<Impulse2>().isLocked = false;
    }
}
