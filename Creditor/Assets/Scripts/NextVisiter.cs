using UnityEngine;
using UnityEngine.Events;

public class NextVisiter : /*Manager<NextVisiter>*/MonoBehaviour
{
    public GameObject Visiter/*, Indicator, ScreenGraph*/;
    public Vector3 Spawn = Vector3.zero;
    public Vector3 actualPosition = new Vector3(0, 0.2f, 0);
    public Color[] CreditHistoryColor = new Color[3];

    public int Graph;
    public int ActualGraph;
    public int ActualCreditHistory;
    public LaptopScript laptop;
    public CreditHistorySCR creditHistory;
    public RulesScript rules;
    //private LaptopScript;
    public UnityEvent newClient;

    private void Awake()
    {

    }
    public void Start()
    {
        laptop = FindObjectOfType<LaptopScript>();
        creditHistory = FindObjectOfType<CreditHistorySCR>();
        rules = FindObjectOfType<RulesScript>();
        NextClient(Random.Range(0, 4));

        Debug.LogError("first client");
    }
/*    public void AwakeCopy()
    {
        NextClient(Random.Range(0, 4));
        Debug.LogError("first client");
    }*/
    /*public void Update()
    {
        if (!FindObjectOfType<VisiterAwake>())
        {
            NextClient(Random.Range(0, 4));
        }
    }*/

    public void NextClient(int Graph)
    {
        /*        if (Graph == 100)
                {
                    Graph = Random.Range(0, 10);
                }

                if (Graph < 3)
                {
                    ActualGraph = Graph;
                    *//*            if (LaptopScript.Instance == null)
                                {
                                    LaptopScript.createInstance();
                                }
                                LaptopScript.Instance.ChangeGraph(ActualGraph);*//*
                    laptop.ChangeGraph(ActualGraph);
                }*/

        //ActualCreditHistory = Random.Range(0, 3);
        //creditHistory.SetHistory(ActualCreditHistory);
        //CreditHistorySCR.Instance.SetHistory(ActualCreditHistory);
        //FindObjectOfType<CreditHistorySCR>().SetHistory(ActualCreditHistory);

        //Indicator = GameObject.FindWithTag("Indicator");
        //newClient.Invoke();

        laptop.newGraph();
        creditHistory.newHistory();
        rules.SetLocalScore();

        /*LaptopScript.Instance.newGraph();
        CreditHistorySCR.Instance.newHistory();
        RulesScript.Instance.SetLocalScore();*/
        //rules.SetLocalScore();
        Instantiate(Visiter, Spawn, Quaternion.identity/*, transform*/);

        /*var CreatedVisiter = */
        //CreatedVisiter.transform.parent = gameObject.transform;

        //rules.localScore = ActualCreditHistory + ActualGraph;
        //RulesScript.Instance.localScore = ActualCreditHistory + ActualGraph;


        //Indicator.GetComponent<SpriteRenderer> ().color = Color.Lerp(Indicator.GetComponent<SpriteRenderer> ().color, CreditHistoryColor[ActualCreditHistory], 1);
    }
}
