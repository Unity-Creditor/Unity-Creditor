using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnderPLASHKASCR : MonoBehaviour
{
    public TextMeshProUGUI stars;
    public TextMeshProUGUI money;

    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void End()
    {
        stars.text = PlayerPrefs.GetInt("localStars").ToString();
        money.text = (PlayerPrefs.GetInt("localStars")*100).ToString();
        PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money")+ (PlayerPrefs.GetInt("localStars") * 100));
    }
}
