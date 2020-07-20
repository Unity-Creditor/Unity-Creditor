using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterSCR : MonoBehaviour
{
    public string nameOfTheDlta;
    
    void Awake()
    {
        PlayerPrefs.SetInt(name,0);
        GetComponentInChildren<TextMeshProUGUI>().text = PlayerPrefs.GetInt(nameOfTheDlta).ToString();
    }

}
