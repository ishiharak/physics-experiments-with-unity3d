using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalGravitation : MonoBehaviour {
    public GameObject target;
    public float G;
    public float m;
    public Vector3 v;
	
	void FixedUpdate () {
        Debug.Log(Time.time);
        Vector3 s = this.transform.position;
        float r = (target.transform.position - this.transform.position).magnitude;
        float M = target.GetComponent<UniversalGravitation>().m;
        Vector3 a = (G * M / (r * r)) * (target.transform.position - this.transform.position).normalized;
        v = v + a * Time.deltaTime;
        s = s + v * Time.deltaTime;
        this.transform.position = s;
	}
}
