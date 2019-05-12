using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameController gameController;

    public float Speed = 5f;

    public GameObject GameLevel;
    public GameObject GameLevelUI;
    public GameObject MenuObjectUI;
    public GameObject MM;
    public GameObject Credit;
    public GameObject CreBut;
    public GameObject Return;
    public GameObject Wordings;

    public bool Move1 = false;

    public void Update()
    {
        if (Move1)
        {
            MoveCanvas();
        }
    }

    public void OnStartPressed()
    {
        Move1 = true;
    }

    public void OnExitPressed()
    {
        Application.Quit();
    }

    public void MoveCanvas()
    {
        gameController.SetMode(GameController.GameMode.GAME);
        MenuObjectUI.transform.Translate(0, transform.position.y * Time.deltaTime * Speed, 0);
        Destroy(MenuObjectUI, 5f);
    }

    public void Credits()
    {
        MM.SetActive(false);
        Credit.SetActive(true);
        Return.SetActive(true);
        CreBut.SetActive(false);
        Wordings.SetActive(false);
    }

    public void CreditsReturn()
    {
        MM.SetActive(true);
        Credit.SetActive(false);
        Return.SetActive(false);
        CreBut.SetActive(true);
        Wordings.SetActive(true);
    }
}