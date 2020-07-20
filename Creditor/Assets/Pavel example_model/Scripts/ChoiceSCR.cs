using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChoiceSCR : MonoBehaviour
{
    TextMeshProUGUI text;
    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    public ChoiceSCR(string text)
    {
        this.text.text = text;
    }//создать bool метод в зависимости от выбора


}
