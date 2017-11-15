using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
    public float Speed = 1f;
    float RotationSpeed = 24f / 60f / 60f;

    void FixedUpdate() {
        transform.Rotate(Vector3.up, Speed * RotationSpeed * Time.deltaTime);
	}
}