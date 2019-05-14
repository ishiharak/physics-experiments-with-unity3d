using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    float x;

    void Start()
    {
        x = 0f;
    }

    void Update()
    {
        x = x + 360f * Mathf.Deg2Rad * Time.deltaTime;
        this.transform.position = new Vector3(5f * Mathf.Sin(x), 0f, 0f);
    }
}
