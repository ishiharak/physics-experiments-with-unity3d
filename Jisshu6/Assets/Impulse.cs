using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{
    public float e;
    public bool isLocked = false;

    void OnTriggerEnter(Collider other)
    {
        if (isLocked == false)
        {
            //float v1 = this.GetComponent<UniformMotion>().v;
            //float v2 = ???;
            //float m1 = ???;
            //float m2 = other.GetComponent<UniformMotion>().m;
            //float v1dash = ???;
            //float v2dash = ((m1+e*m1)*v1+(m2-e*m1)*v2)/(m1+m2);
            //this.GetComponent<UniformMotion>().v = v1dash;
            //other.GetComponent<UniformMotion>().v = v2dash;
            other.GetComponent<Impulse>().isLocked = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Impulse>().isLocked = false;
    }
}
