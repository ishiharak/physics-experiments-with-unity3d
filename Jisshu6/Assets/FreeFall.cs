using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeFall : MonoBehaviour
{
    public float v0, g;
    public float v;
    public Vector3 PreviousPosition;

    void Start()
    {
        v = v0;
    }

    void Update()
    {
        float y = this.transform.position.y;
        v = v + g * Time.deltaTime;
        y = y + v * Time.deltaTime;
        PreviousPosition = this.transform.position;
        this.transform.position = new Vector3(0f, y, 0f);
    }
}
