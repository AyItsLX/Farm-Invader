using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flew : MonoBehaviour {

    public Rigidbody myRB;
    public GameObject Boom;
    public GameObject Trail;
    public GameObject Bomb;
    public GameObject Fire;
    public bool isTime = false;
    public int ThisDmg = 50;
    public float Dist = 1f;
    public float Height = 1f;
    public float MaxTime = 2;
    public double Timer = 0;

    public void Awake()
    {
        Vector3 newPoss = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y * Height, gameObject.transform.position.z * -Dist);
        myRB.AddForce(newPoss);
        isTime = true;
    }

    public void Update()
    {

        if (isTime)
        {
            Timer += Time.deltaTime;
            if (Timer >= MaxTime)
            {
                Destroy(gameObject);
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        BossHP HP = other.gameObject.GetComponent<BossHP>();

        if (other.CompareTag("Boss"))
        {
            HP.HealthPoints -= ThisDmg;
            Instantiate(Boom, transform.position, transform.rotation);
            GetComponent<AudioSource>().Play();
            Trail.SetActive(false);
            Bomb.SetActive(false);
            Fire.SetActive(false);
            Destroy(gameObject, GetComponent<AudioSource>().clip.length);
        }
    }
}
