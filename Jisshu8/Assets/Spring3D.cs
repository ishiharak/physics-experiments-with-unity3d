using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring3D : MonoBehaviour
{
    public float k, m;
    public float v;

    void Update()
    {
        float s = this.transform.position.x;
        float a = -k * s / m;
        v = v + a * Time.deltaTime;
        s = s + v * Time.deltaTime;
        this.transform.position = new Vector3(s, 0f, 0f);
    }
}
