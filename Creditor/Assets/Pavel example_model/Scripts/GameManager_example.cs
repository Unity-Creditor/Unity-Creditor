using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_example : MonoBehaviour
{
    public GameObject label;
/*    public GameObject computer;*/
    public GameObject store;
    public GameObject[] environment;
    public GameObject AwakeButton;
    private void Awake()
    {
        label.SetActive(true);
/*        computer.SetActive(true);*/
        //store.SetActive(true); его пока нет
        foreach (GameObject smth in environment)
        {
            smth.SetActive(false);
        }
        AwakeButton.SetActive(true);
    }
    public void AwakeTheGame()
    {
        label.SetActive(false);
        AwakeButton.SetActive(false);
        /*        computer.SetActive(true);*/
        //store.SetActive(true); его пока нет
        foreach (GameObject smth in environment)
        {
            smth.SetActive(true);
        }
    }
}
