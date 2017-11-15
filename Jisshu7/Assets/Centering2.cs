using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centering2 : MonoBehaviour {
    public GameObject ObjectA, ObjectB;

    void Update()
    {
        Vector3 a = ObjectA.transform.position;
        Vector3 b = ObjectB.transform.position;
        //this.transform.position = ???;
    }
}
