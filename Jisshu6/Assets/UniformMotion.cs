using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniformMotion : MonoBehaviour
{
    public float v, m;

    void FixedUpdate()
    {
        this.transform.Translate(v * Time.deltaTime, 0f, 0f);
    }
}
