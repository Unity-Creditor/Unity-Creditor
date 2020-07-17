using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NextVisiter : MonoBehaviour
{
    public GameObject Visiter, Indicator, ScreenGraph;
    // public ScreenGraph ScreenGraphTest;
    public Vector3 Spawn = Vector3.zero;
    public Vector3 actualPosition = new Vector3(0, 0.2f, 0);
    public Color[] CreditHistoryColor = new Color[3];

    public int Graph;
    public int ActualGraph;
    public int ActualCreditHistory;

    //private LaptopScript;

    public void Start()
    {
      ActualGraph = Random.Range(0, 3);
      GraphGenerator(ActualGraph);
      //RulesScript.Instance.localScore = ActualCreditHistory;
      //Debug.Log("gg");

      //ScreenGraph.GetComponent<LaptopScript>().ChangeGraph(ActualGraph);
      Invoke("NextClient", 0);
      //RulesScript RulesBlock = gameObject.GetComponent<RulesScript>();

    }

    public void NextClient()
    {
      Graph = Random.Range(0, 10);
      ScreenGraph = GameObject.FindWithTag("ScreenGraph");
      if (Graph < 3)
      {
        ActualGraph = Graph;
        ScreenGraph.GetComponent<LaptopScript>().ChangeGraph(ActualGraph);
      }

      Indicator = GameObject.FindWithTag("Indicator");

      var CreatedVisiter = Instantiate(Visiter, Spawn, Quaternion.identity);
      ActualCreditHistory = Random.Range(0, 3);
      //Debug.Log(ActualCreditHistory);

      Graph = Random.Range(0, 10);

      //GraphGenerator(Graph);

      // GameObject.FindWithTag("GameController").GetComponent<RulesScript>().localScore = ActualCreditHistory;
      //GameObject.FindWithTag("GameController").GetComponent<RulesScript>().localScore = ActualCreditHistory + ActualGraph;

      RulesScript.Instance.localScore = ActualCreditHistory + ActualGraph;

      Indicator.GetComponent<SpriteRenderer> ().color = Color.Lerp(Indicator.GetComponent<SpriteRenderer> ().color, CreditHistoryColor[ActualCreditHistory], 1);
    }


    public void GraphGenerator(int GraphI)
    {
      Debug.Log(GraphI);
      //GraphI = Random.Range(0, 10);
      ScreenGraph = GameObject.FindWithTag("ScreenGraph");
      if (Graph < 3)
      {
        ActualGraph = Graph;
        ScreenGraph.GetComponent<LaptopScript>().ChangeGraph(ActualGraph);
      }

    }
}
