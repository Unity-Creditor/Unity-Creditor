﻿using UnityEngine;

public class NextVisiter : MonoBehaviour
{
    public GameObject Visiter, Indicator, ScreenGraph;
    public Vector3 Spawn = Vector3.zero;
    public Vector3 actualPosition = new Vector3(0, 0.2f, 0);
    public Color[] CreditHistoryColor = new Color[3];

    public int Graph;
    public int ActualGraph;
    public int ActualCreditHistory;

    //private LaptopScript;

    public void Start()
    {
        NextClient(Random.Range(0, 4));
    }

    public void NextClient(int Graph)
    {
        if (Graph == 100)
        {
            Graph = Random.Range(0, 10);
        }

        if (Graph < 3)
        {
            ActualGraph = Graph;
            LaptopScript.Instance.ChangeGraph(ActualGraph);
        }

        //Indicator = GameObject.FindWithTag("Indicator");

        var CreatedVisiter = Instantiate(Visiter, Spawn, Quaternion.identity/*, transform*/);
        //CreatedVisiter.transform.parent = gameObject.transform;
        ActualCreditHistory = Random.Range(0, 3);


        RulesScript.Instance.localScore = ActualCreditHistory + ActualGraph;

        CreditHistorySCR.Instance.SetHistory(ActualCreditHistory);
        //Indicator.GetComponent<SpriteRenderer> ().color = Color.Lerp(Indicator.GetComponent<SpriteRenderer> ().color, CreditHistoryColor[ActualCreditHistory], 1);
    }
}
