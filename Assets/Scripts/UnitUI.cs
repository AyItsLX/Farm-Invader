using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitUI : MonoBehaviour {

    public GBText gBText;
    public GoldUpg goldUpg;
    public CarrotCounter goldCount;
    public GameObject neg;
    public ThrowNade throwNade;

    public GameObject monsterPrefab;
    private GameObject monster;
    public float MaxRadius = 6f;
    public double Timer = 0;
    public double TimerMax = 1;
    public GameObject gameObj;
    public bool timer = false;


    [SerializeField]
    private Transform Origin = null;

    public void Unit_1()
    {
        if (goldCount.Gold >= 50)
        {
            //if (Origin == null) return;
            throwNade.Throw();
            goldCount.Gold -= 50;
            GBText.goldcount = (int)goldCount.Gold;
            //Spawn();
        }
        else
        {
            gameObj = neg;
            neg.SetActive(true);
            timer = true;
            Check();
        }
    }

    public void Unit_2()
    {
        if (goldCount.Gold >= 500)
        {
            throwNade.Rocket();
            goldCount.Gold -= 500;
            GBText.goldcount = (int)goldCount.Gold;
        }
        else
        {
            gameObj = neg;
            neg.SetActive(true);
            timer = true;
            Check();
        }
    }

    public void Spawn()
    {
        if (Origin == null) return;
        Vector3 SpawnPos = Origin.position + Random.onUnitSphere * MaxRadius;
        SpawnPos = new Vector3(SpawnPos.x, 2f, SpawnPos.z);
        Instantiate(monsterPrefab, SpawnPos, Quaternion.identity);
    }

    public void Update()
    {
        if (timer)
        {
            Timer += Time.deltaTime;
            Check();
        }
    }
    public void Check()
    {
        if (Timer >= TimerMax)
        {
            gameObj.SetActive(false);
            //print("Working");
            timer = false;
            Timer = 0;
        }
    }
}
