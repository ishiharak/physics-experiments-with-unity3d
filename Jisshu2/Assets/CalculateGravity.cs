using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateGravity : MonoBehaviour
{

    void Start()
    {

    }

    void FixedUpdate()
    {
        print(Time.time);
        print(this.transform.position.y);
    }
}
