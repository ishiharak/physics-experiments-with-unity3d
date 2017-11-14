using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour {
    public GameObject[] Vectors;

    void Start() {
        this.GetComponent<LineRenderer>().positionCount = Vectors.Length;
    }

    void Update () {
        for (int i = 0; i < Vectors.Length; i++) {
			this.GetComponent<LineRenderer>().SetPosition(i, Vectors[i].transform.position);
        }
	}
}
