using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalGravitation : MonoBehaviour {
    public float G;
    public float m;
    public GameObject target;
    Vector3 v;

	void Start () {
        Debug.Log(G * 60 * 60 * 24 * 60 * 60 * 24);
        v = Vector3.zero;
	}
	
	void Update () {
        Vector3 s = this.transform.position;
        float r = (target.transform.position - this.transform.position).magnitude;
        float M = target.GetComponent<UniversalGravitation>().m;
        Vector3 a = (G * M / (r * r)) * (target.transform.position - this.transform.position).normalized;
        //Debug.Log(a);
        v = v + a * Time.deltaTime;
        s = s + v * Time.deltaTime;
        this.transform.position = s;
	}
}
