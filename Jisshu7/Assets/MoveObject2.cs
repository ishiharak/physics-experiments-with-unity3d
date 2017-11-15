using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject2 : MonoBehaviour {
    public GameObject ObjectA;
    public Vector3 c;
	
    void Update () {
        Vector3 a = ObjectA.transform.position;
        //this.transform.position = a ???;
	}
}
