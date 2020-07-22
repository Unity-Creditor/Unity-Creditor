using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TaskSCR : MonoBehaviour /*Manager<TaskSCR>*/
{
    public GameObject[] creditType;
    public GameObject winPanel;
    private void Start()
    {
        //PlayerPrefs.SetInt("creditType",0);
        winPanel.SetActive(true);
        Disabler();
        creditType[PlayerPrefs.GetInt("creditType")].SetActive(true);
        FindObjectOfType<RulesScript>().isEnd = true;
    }
    public void Disabler()
    {
        foreach (var item in creditType)
        {
            item.SetActive(false);
        }
    }
}
