using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTrig : MonoBehaviour {

    public Transform Thistransform;
    public float RotationSpeed = 20;

    void Update()
    {
        Thistransform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));

    }
}
