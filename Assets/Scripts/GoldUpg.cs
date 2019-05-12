using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldUpg : MonoBehaviour {

    public double Timer = 0;
    public double TimerMax = 1;
    public double Timer2 = 0;
    public double TimerMax2 = 1;
    public int plus = 5;
    public int plusie = 0;
    public bool Got = true; // Got = "Gold Over Time".
    public CarrotCounter goldCounter;

    public GameObject neg;
    public GameObject plus1;
    public GameObject plus1b;
    public GameObject plus2;
    public GameObject plus2b;
    public GameObject plus3;
    public GameObject plus3b;
    public GameObject sec1;
    public GameObject sec1b;
    public GameObject sec2;
    public GameObject sec2b;

    public GameObject gameObj;
    public GameObject gameObj2;
    public bool timer = false;
    public bool timer2 = false;


    public void Plus1()
    {
        if (goldCounter.Gold >= 100)
        {
            plus1b.SetActive(true);
            gameObj = plus1b;
            goldCounter.Gold -= 100;
            plusie = 10;
            goldCounter.incre = plusie;
            GBText.percc = plusie;
            GBText.goldcount = (int)goldCounter.Gold;
            plus1.SetActive(false);
            plus2.SetActive(true);
            timer = true;
            Check();
        }
        else
            NotEnough();
    }
    public void Plus2()
    {
        if (goldCounter.Gold >= 1000)
        {
            plus2b.SetActive(true);
            gameObj2 = plus2b;
            goldCounter.Gold -= 1000;
            plusie = 20;
            goldCounter.incre = plusie;
            GBText.percc = plusie;
            GBText.goldcount = (int)goldCounter.Gold;
            plus2.SetActive(false);
            plus3.SetActive(true);
            timer2 = true;
            Check();
        }
        else
            NotEnough2();
    }
    public void Plus3()
    {
        if (goldCounter.Gold >= 5000)
        {
            gameObj = plus3b;
            goldCounter.Gold -= 5000;
            plusie = 50;
            goldCounter.incre = plusie;
            GBText.percc = plusie;
            GBText.goldcount = (int)goldCounter.Gold;
            plus3.SetActive(false);
            plus3b.SetActive(true);
            timer = true;
            Check();
        }
        else
            NotEnough();
    }


    public void Sec1()
    {
        if (goldCounter.Gold >= 5000)
        {
            gameObj = sec1b;
            goldCounter.Gold -= 5000;
            plus = 20;
            GBText.goldcount = (int)goldCounter.Gold;
            sec1.SetActive(false);
            sec1b.SetActive(true);
            sec2.SetActive(true);
            timer = true;
            Check();
        }
        else
            NotEnough();
    }
    public void Sec2()
    {
        if (goldCounter.Gold >= 25000)
        {
            gameObj = sec2b;
            goldCounter.Gold -= 25000;
            plus = 50;
            GBText.goldcount = (int)goldCounter.Gold;
            sec2.SetActive(false);
            sec2b.SetActive(true);
            timer = true;
            Check();
        }
        else
            NotEnough();
    }





 
    public void Update()
    {
        goldCounter.Gold += plus * Time.deltaTime;
        GBText.perss = plus;
        GBText.goldcount = (int)goldCounter.Gold;
        if (timer)
        {
            Timer += Time.deltaTime;
            Check();
        }
        if (timer2)
        {
            Timer2 += Time.deltaTime;
            Check();
        }
    }
    public void Check()
    {
        if (Timer >= TimerMax)
        {
            gameObj.SetActive(false);
            timer = false;
            Timer = 0;
        }
        if (Timer2 >= TimerMax2)
        {
            gameObj2.SetActive(false);
            timer2 = false;
            Timer2 = 0;
        }
    }
    public void NotEnough()
    {
        gameObj = neg;
        neg.SetActive(true);
        timer = true;
        Check();
    }
    public void NotEnough2()
    {
        gameObj2 = neg;
        neg.SetActive(true);
        timer2 = true;
        Check();
    }
}
