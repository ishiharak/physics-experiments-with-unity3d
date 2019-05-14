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
        //if (Time.time ???) {
        //x = x + ??? * Mathf.Deg2Rad * Time.deltaTime;
        this.transform.position = new Vector3(3f * Mathf.Sin(x), 0f, 0f);
        //if (this.transform.position.x ???) {
        //	this.GetComponent<MeshRenderer> ().material.color = Color.red;
        //} else {
        //	this.GetComponent<MeshRenderer> ().material.color = Color.blue;
        //}
        //}
    }
}
