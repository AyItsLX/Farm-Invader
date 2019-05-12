using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daytime : MonoBehaviour {

    public Transform Thistransform;
    public float RotationSpeed = 20;

	void Update () {
        Thistransform.Rotate(Vector3.left * (RotationSpeed * Time.deltaTime));

    }
}
