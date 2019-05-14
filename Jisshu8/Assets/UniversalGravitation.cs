using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalGravitation : MonoBehaviour
{
    public bool Freeze;
    public GameObject target;
    public float G;
    public float m;
    public Vector3 v;

    void FixedUpdate()
    {
        if (Freeze) return;
        Vector3 s = this.transform.position;
        //float r = ???;
        //float M = ???;
        //Vector3 a = ???;
        //v = ???;
        //s = ???;
        this.transform.position = s;
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Hit");
    }
}
