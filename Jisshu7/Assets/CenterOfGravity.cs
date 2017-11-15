using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterOfGravity : MonoBehaviour {
    public GameObject ObjectA, ObjectB, ObjectC, ObjectD;

    void Update()
    {
        Vector3 a = ObjectA.transform.position;
        Vector3 b = ObjectB.transform.position;
        Vector3 c = ObjectC.transform.position;
        Vector3 d = ObjectD.transform.position;
        //this.transform.position = ???;
    }
}
