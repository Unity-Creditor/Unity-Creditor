using UnityEngine;

public class LaptopScript : MonoBehaviour/*Manager<LaptopScript>*/
{
    public int actualGraph;
    public GameObject[] ScreenArts = new GameObject[3];

/*    static public void createInstance()
    {
        m_Instance = new LaptopScript();
    }*/
    void Start()
    {
        ScreenArts[0].SetActive(false);
        ScreenArts[1].SetActive(false);
        ScreenArts[2].SetActive(false);
    }

    public void ChangeGraph(int GraphControl)
    {
        actualGraph = GraphControl;
        /*Debug.Log("Graph changed");*/
        if (GraphControl == 0)
        {
            ScreenArts[0].SetActive(true);
            ScreenArts[1].SetActive(false);
            ScreenArts[2].SetActive(false);
            Debug.Log("Graph changed 0");
        }
        if (GraphControl == 1)
        {
            ScreenArts[0].SetActive(false);
            ScreenArts[1].SetActive(true);
            ScreenArts[2].SetActive(false);
            Debug.Log("Graph changed 1");
        }
        if (GraphControl == 2)
        {
            ScreenArts[0].SetActive(false);
            ScreenArts[1].SetActive(false);
            ScreenArts[2].SetActive(true);
            Debug.Log("Graph changed 2");
        }
/*        if (GraphControl == 3)
        {
            ScreenArts[0].SetActive(true);
            ScreenArts[1].SetActive(false);
            ScreenArts[2].SetActive(false);
        }*/
        /*      if (GraphControl != ActualGraph)
              {
                ScreenArts[ActualGraph].SetActive(false);
                ActualGraph = GraphControl;
                ScreenArts[GraphControl].SetActive(true);
              }*/

    }
    public void newGraph()
    {
        int graph = Random.Range(0,10);
        if (graph < 3)
        {
            actualGraph = graph;
            /*            if (LaptopScript.Instance == null)
                        {
                            LaptopScript.createInstance();
                        }
                        LaptopScript.Instance.ChangeGraph(ActualGraph);*/
            ChangeGraph(actualGraph);
        }
    }
}
