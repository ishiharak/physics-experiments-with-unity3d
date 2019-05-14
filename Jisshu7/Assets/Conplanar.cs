using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conplanar : MonoBehaviour
{
    public GameObject ObjectB, ObjectC, ObjectD;

    void Update()
    {
        Vector3 a = this.transform.position;
        Vector3 b = ObjectB.transform.position;
        Vector3 c = ObjectC.transform.position;
        Vector3 d = ObjectD.transform.position;
        //続きは自由に考えて下さい
    }
}
