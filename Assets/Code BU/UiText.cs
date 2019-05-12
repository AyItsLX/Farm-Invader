using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiText : MonoBehaviour {

    //public GoldCounter goldCounter;
    public static int goldcount;
    public Text goldCount;

    public void Update()
    {
        Updatetext();
    }

    public void Updatetext()
    {
        goldCount.text = "Gold : " + goldcount;
    }
}
