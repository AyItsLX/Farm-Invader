using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarrotCounter : MonoBehaviour {

    public double Gold;
    public int incre = 5;
    public GameObject C1;
    public GameObject C2;

    public void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Q))
        {
            C1.SetActive(false);
            C2.SetActive(true);
            GetCarrot();
            GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            C1.SetActive(true);
            C2.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            C1.SetActive(false);
            C2.SetActive(true);
            GetCarrot();
            GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            C1.SetActive(true);
            C2.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            C1.SetActive(false);
            C2.SetActive(true);
            GetCarrot();
            GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            C1.SetActive(true);
            C2.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            C1.SetActive(false);
            C2.SetActive(true);
            GetCarrot();
            GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            C1.SetActive(true);
            C2.SetActive(false);
        }
    }

    public void GetCarrot()
    {
        Gold += incre;
        GBText.goldcount = (int)Gold;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
