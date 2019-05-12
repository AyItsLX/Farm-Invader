using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public Transform ObjToFollow = null;
    public bool FollowPlayer = false;
    private Transform ThisTransform = null;
    public float MaxSpeed = 1f;

    public void Awake()
    {
        ThisTransform = GetComponent<Transform>();
        GameObject PlayerObj = GameObject.FindGameObjectWithTag("Boss");
        ObjToFollow = PlayerObj.GetComponent<Transform>();
    }

	public void Update()
    {
        if (ObjToFollow == null)
            return;

        Vector3 tempVec  = new Vector3(ObjToFollow.position.x, ThisTransform.position.y, ObjToFollow.position.z);

        Vector3 DirToObject = tempVec - ThisTransform.position;

        if (DirToObject != Vector3.zero)
        {
            ThisTransform.localRotation = Quaternion.LookRotation(DirToObject.normalized, Vector3.up);
            ThisTransform.position += ThisTransform.forward * MaxSpeed * Time.deltaTime;
        }
    }
}
