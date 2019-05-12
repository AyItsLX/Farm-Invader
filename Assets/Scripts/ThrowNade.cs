using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowNade : MonoBehaviour {

    public GameObject Obj1;
    public Transform Obj;
    public GameObject Nade;
    public GameObject Rockey;
    public float MaxTime = 0.5f;
    public double Timer = 0;
    public bool isTime = false;
    public bool isCooldown = false;
    public GameObject DevRocket;

    [SerializeField]
    private Transform Origin = null;

    private void Awake()
    {
        Obj = Obj1.transform;
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            DevRock();
        }
        if (isCooldown)
        {
            isTime = true;
            if (isTime)
            {
                Timer += Time.deltaTime;
            }
            if (Timer >= MaxTime)
            {
                isCooldown = false;
                isTime = false;
                Timer = 0;
            }
        }
    }

    public void Throw()
    {
        if (!isCooldown)
        {
            Vector3 SpawnPos = Origin.position + Random.onUnitSphere * 0.6f;
            isCooldown = true;
            Instantiate(Nade, SpawnPos, Nade.transform.rotation);
        }
    }

    public void Rocket()
    {
        if (!isCooldown)
        {
            Vector3 SpawnPos = Origin.position + Random.onUnitSphere * 0.6f;
            isCooldown = true;
            Instantiate(Rockey, SpawnPos, Rockey.transform.rotation);
        }
    }

    public void DevRock()
    {
        if (!isCooldown)
        {
            Vector3 SpawnPos = Origin.position + Random.onUnitSphere * 0.6f;
            isCooldown = true;
            Instantiate(DevRocket, SpawnPos, DevRocket.transform.rotation);
        }
    }
}
