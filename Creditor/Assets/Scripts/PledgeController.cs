using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PledgeController : MonoBehaviour
{
    public int actualPledge;

    public GameObject[] laptop;
    public GameObject[] manCard;

    private void Start()
    {
        Disabler();
    }
    void Disabler()
    {
        foreach (var item in laptop)
        {
            item.SetActive(false);
        }
        foreach (var item in manCard)
        {
            item.SetActive(false);
        }
    }
    void SetPledge(int quality)
    {
        Disabler();
        laptop[quality].SetActive(true);
        manCard[quality].SetActive(true);
    }
    public void newPledge()
    {
        actualPledge = Random.Range(0, 6);
        SetPledge(actualPledge);
    }
}
