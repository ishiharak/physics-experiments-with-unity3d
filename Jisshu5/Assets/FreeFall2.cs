using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeFall2 : MonoBehaviour
{
    public float v0, g;
    float v;

    void Start()
    {
        v = v0;
    }

    void Update()
    {
        float y = this.transform.position.y;
        //v = ???;
        //y = ???;
        this.transform.position = new Vector3(0f, y, 0f);
    }
}
