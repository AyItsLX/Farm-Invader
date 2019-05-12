using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCounter : MonoBehaviour {

    //public UiText uiText;
    public GameObject g;
    public double Gold;
    public int incre = 1;
    public int a = 0;

    void Start()
    {
        g = GameObject.FindGameObjectWithTag("Gold");

        if (g == true)
        {
            OnMouseOver();
        }
    }

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Gold += incre;
            UiText.goldcount = (int)Gold;
            //print(Gold);
        }
    }

    //void Update()
    //{
    //    GoldGained();
    //}
    //void GoldGained()
    //{
    //    if(Input.GetKeyDown(KeyCode.Z))
    //    {
    //        Gold += 1;
    //        print(Gold);
    //    }
    //}
}
