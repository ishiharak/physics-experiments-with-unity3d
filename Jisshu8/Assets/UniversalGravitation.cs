using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UniversalGravitation : MonoBehaviour {
    public bool Freeze;
    public GameObject target;
    public float G;
    public float m;
    public Vector3 v;
    public Text text;
    private bool flag = false;

    void FixedUpdate () {
        if (Freeze) return;
        Vector3 s = this.transform.position;
        float r = (target.transform.position - this.transform.position).magnitude;
        float M = target.GetComponent<UniversalGravitation>().m;
        Vector3 a = G * M / (r * r) * (target.transform.position - this.transform.position).normalized;
        v = v + a * Time.deltaTime;
        s = s + v * Time.deltaTime;
        this.transform.position = s;
        if(!flag) text.text = Time.time.ToString("N1") + "日";
	}

    private void OnTriggerEnter(Collider other) {
        flag = true;
        text.color = Color.red;
        Freeze = true;
        target.GetComponent<UniversalGravitation>().Freeze = true;
    }
}
