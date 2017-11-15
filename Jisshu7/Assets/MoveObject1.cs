using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject1 : MonoBehaviour {
    public GameObject ObjectA;

	void Update () {
        Vector3 a = ObjectA.transform.position;
        //this.transform.position = a ???;
	}
}
