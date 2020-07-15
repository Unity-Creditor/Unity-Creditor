using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_example : MonoBehaviour
{
    public GameObject label;
/*    public GameObject computer;*/
    public GameObject store;
    public GameObject[] environment;
    public GameObject startButton;
    private void Start()
    {
        label.SetActive(true);
/*        computer.SetActive(true);*/
        //store.SetActive(true); его пока нет
        foreach (GameObject smth in environment)
        {
            smth.SetActive(false);
        }
        startButton.SetActive(true);
    }
    public void StartTheGame()
    {
        label.SetActive(false);
        startButton.SetActive(false);
        /*        computer.SetActive(true);*/
        //store.SetActive(true); его пока нет
        foreach (GameObject smth in environment)
        {
            smth.SetActive(true);
        }
    }
}
