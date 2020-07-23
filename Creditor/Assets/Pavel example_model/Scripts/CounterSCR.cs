using TMPro;
using UnityEngine;

public class CounterSCR : MonoBehaviour
{
    public string nameOfTheDlta;


    void Start()
    {
        PlayerPrefs.SetInt(name, 0);
        GetComponentInChildren<TextMeshProUGUI>().text = PlayerPrefs.GetInt(nameOfTheDlta).ToString();
    }
    private void OnEnable()
    {
        PlayerPrefs.SetInt(name, 0);
        GetComponentInChildren<TextMeshProUGUI>().text = PlayerPrefs.GetInt(nameOfTheDlta).ToString();

    }

}
