using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse3D : MonoBehaviour
{
    public float e;
    public bool isLocked = false;

    void OnTriggerEnter(Collider other)
    {
        if (isLocked) return;
        //float v1 = this.GetComponent<FreeFall3D>().v;
        //float v2 = ???;
        //float m1 = ???;
        //float m2 = other.GetComponent<FreeFall3D>().m;
        //float v1dash = ((m1 - e * m2) * v1 + (m2 + e * m2) * v2) / (m1 + m2);
        //float v2dash = ???;
        //this.GetComponent<FreeFall3D>().v = v1dash;
        //other.GetComponent<FreeFall3D>().v = ???;
        //other.GetComponent<Impulse3D>().isLocked = true;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Impulse3D>().isLocked = false;
    }
}
