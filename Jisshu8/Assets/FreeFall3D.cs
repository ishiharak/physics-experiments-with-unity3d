using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeFall3D : MonoBehaviour {
    public float v, g;
    public float m;

    void FixedUpdate()
    {
        float s = this.transform.position.y;
        v = v + g * Time.deltaTime;
        s = s + v * Time.deltaTime;
        this.transform.position = new Vector3(0f, s, 0f);
    }
}
