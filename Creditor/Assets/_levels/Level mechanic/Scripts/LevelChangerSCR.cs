using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelChangerSCR : MonoBehaviour
{
    public GameObject[] levelList;
    public TextMeshProUGUI text;
    public int bank = 0;
    private void Start()
    {
        SetBank();
    }
    void Disabler()
    {
        foreach (var item in levelList)
        {
            item.SetActive(false);
        }
    }
    void SetBank()
    {
        Disabler();
        text.text = "Bank " + (bank + 1);
        levelList[bank].SetActive(true);
    }
    public void NextBank()
    {
        bank++;
        if (bank >= levelList.Length)
        {
            bank = 0;
        }
        SetBank();
    }
    public void LastBank()
    {
        bank--;
        if (bank < 0)
        {
            bank = levelList.Length-1;
        }
        SetBank();
    }
}

