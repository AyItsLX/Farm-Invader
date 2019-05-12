using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject GameLevel;
    //public GameObject MenuObject;

    public GameObject GameLevelUI;
    public GameObject MenuObjectUI;

    public bool isGameActive;
    public bool isMenuActive;

    public enum GameMode { GAME, MENU};

    void Start()
    {
        GetComponent<AudioSource>().Play();
        SetMode(GameMode.MENU);
    }
    public void SetMode(GameMode mode) {
        if (mode == GameMode.GAME)
        {
            GameLevel.SetActive(true);
            GameLevelUI.SetActive(true);
            //MenuObject.SetActive(false);
            //MenuObjectUI.SetActive(false);
        }
        else if (mode == GameMode.MENU)
        {
            GameLevel.SetActive(false);
            GameLevelUI.SetActive(false);
            //MenuObject.SetActive(true);
            MenuObjectUI.SetActive(true);
        }
    }
}
