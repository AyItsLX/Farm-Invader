using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    public GameObject target;
    public GameObject Fire;
    public GameObject Explode;
    public AudioSource Fly;
    public AudioSource Boom;
    public GameObject thisRocket;
    public float speed;
    public int ThisDmg = 50;

    public void Awake()
    {
        Fly.Play();
        target = GameObject.FindGameObjectWithTag("Boss");
    }

    void Update()
    {
        speed += Time.deltaTime * 25;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
    }

    public void OnTriggerEnter(Collider other)
    {
        BossHP HP = other.gameObject.GetComponent<BossHP>();

        if (other.CompareTag("Boss"))
        {
            HP.HealthPoints -= ThisDmg;
            Instantiate(Explode, transform.position, transform.rotation);
            Boom.Play();
            GetComponent<CapsuleCollider>().enabled = false;
            thisRocket.SetActive(false);
            Fire.SetActive(false);
            Destroy(gameObject, Boom.clip.length);
        }
    }
}
