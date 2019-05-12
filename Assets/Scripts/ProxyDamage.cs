using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxyDamage : MonoBehaviour {

    public int Damage = 10;
    public GameObject DeathParticlesPrefab = null;
    private Transform ThisTransform = null;
    public GameObject Sprite;

    void Start()
    {
        ThisTransform = GetComponent<Transform>();
    }

    public void OnTriggerEnter(Collider Col)
    {
        BossHP HP = Col.gameObject.GetComponent<BossHP>();

        if (HP == null)
            return;

        if (DeathParticlesPrefab != null)
        {
            Instantiate(DeathParticlesPrefab, ThisTransform.position, ThisTransform.rotation);
        }
        Sprite.SetActive(false);
        GetComponent<AudioSource>().Play();
        GetComponent<CapsuleCollider>().enabled = false;
        HP.HealthPoints -= Damage;
        Destroy(gameObject, GetComponent<AudioSource>().clip.length);
    }
}
