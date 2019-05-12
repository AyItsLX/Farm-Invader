using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHP : MonoBehaviour
{
    public GameObject B1;
    public GameObject B2;
    public GameObject B3;
    public GameObject B4;
    public GameObject GOText;
    public GameObject BBtext;
    public GBText gBText;
    public Transform Thistransform;
    public GameObject Shoota;
    public GameObject bossText;
    public GameObject End;
    public GameObject Restart;
    //public float Thistimer = 2;

    [SerializeField]
    private int _bossHP = 10000;

    void Update()
    {
        GBText.bhp = _bossHP;
        //Thistimer -= Time.deltaTime;
        gBText.bosHP.value = HealthPoints;
    }

    public int HealthPoints
    {
        get
        {
            return _bossHP;
        }

        set
        {
            _bossHP = value;

            if (_bossHP <= 0)
            {
                if (B1.GetComponent<BossHP>().HealthPoints <= 0)
                {
                    gBText.bosHP.maxValue = 25000;
                    HealthPoints = 25000;
                    B1.SetActive(false);
                    B2.SetActive(true);
                }
                if (B2.GetComponent<BossHP>().HealthPoints <= 0)
                {
                    gBText.bosHP.maxValue = 50000;
                    HealthPoints = 50000;
                    B2.SetActive(false);
                    B3.SetActive(true);
                }
                if (B3.GetComponent<BossHP>().HealthPoints <= 0)
                {
                    gBText.bosHP.maxValue = 100000;
                    HealthPoints = 100000;
                    B3.SetActive(false);
                    B4.SetActive(true);
                }
                if (B4.GetComponent<BossHP>().HealthPoints <= 0)
                {
                    gBText.bosHP.maxValue = 0;
                    bossText.SetActive(false);
                    BBtext.SetActive(true);
                    B4.SetActive(false);
                    Destroy(GameObject.FindGameObjectWithTag("Enemy"));
                    Shoota.SetActive(false);
                    GOText.SetActive(true);
                    End.SetActive(true);
                    Restart.SetActive(true);
                }
            }
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
            Thistransform.position = new Vector3(0, 4, Thistransform.position.z);
        }
    }
}
