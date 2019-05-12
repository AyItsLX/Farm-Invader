using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GBText : MonoBehaviour {

    public BossHP bossHP;
    public static int goldcount;
    public static int bhp;
    public static int perss;
    public static int percc = 5;
    public Text goldCount;
    public Text bossHp;
    public Text pers;
    public Text perc;
    public Slider bosHP;

    public int currentGold;

    public void Update()
    {
        Updatetext();
        //bosHP.value = bossHP.HealthPoints;
        //print("bossHP.HealthPoints: " + bossHP.HealthPoints);
    }

    public void Updatetext()
    {
        bossHp.text = "" + bhp;
        //goldCount.text = "Carrot : " + goldcount;
        currentGold = Mathf.FloorToInt(Mathf.Lerp(currentGold, goldcount, Time.deltaTime * 10));
        goldCount.text = "Carrot : " + currentGold;
        pers.text = "Carrot : "+perss+" /s";
        perc.text = "Carrot : " +percc+ " per click";
    }


}
