using UnityEngine;

public class NextVisiter : /*Manager<NextVisiter>*/MonoBehaviour
{
    public GameObject Visiter, Indicator, ScreenGraph;
    public Vector3 Spawn = Vector3.zero;
    public Vector3 actualPosition = new Vector3(0, 0.2f, 0);
    public Color[] CreditHistoryColor = new Color[3];

    public int Graph;
    public int ActualGraph;
    public int ActualCreditHistory;
    LaptopScript laptop;
    CreditHistorySCR creditHistory;
    RulesScript rules;
    //private LaptopScript;

    private void Awake()
    {
        laptop = FindObjectOfType<LaptopScript>();
        creditHistory = FindObjectOfType<CreditHistorySCR>();
        rules = FindObjectOfType<RulesScript>();
    }
    public void Start()
    {
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
        if (Graph == 100)
        {
            Graph = Random.Range(0, 10);
        }

        if (Graph < 3)
        {
            ActualGraph = Graph;
            /*            if (LaptopScript.Instance == null)
                        {
                            LaptopScript.createInstance();
                        }
                        LaptopScript.Instance.ChangeGraph(ActualGraph);*/
            laptop.ChangeGraph(ActualGraph);
        }

        ActualCreditHistory = Random.Range(0, 3);
        creditHistory.SetHistory(ActualCreditHistory);
        //CreditHistorySCR.Instance.SetHistory(ActualCreditHistory);
        //FindObjectOfType<CreditHistorySCR>().SetHistory(ActualCreditHistory);

        //Indicator = GameObject.FindWithTag("Indicator");

        /*var CreatedVisiter = */Instantiate(Visiter, Spawn, Quaternion.identity/*, transform*/);
        //CreatedVisiter.transform.parent = gameObject.transform;

        rules.localScore = ActualCreditHistory + ActualGraph;
        //RulesScript.Instance.localScore = ActualCreditHistory + ActualGraph;


        //Indicator.GetComponent<SpriteRenderer> ().color = Color.Lerp(Indicator.GetComponent<SpriteRenderer> ().color, CreditHistoryColor[ActualCreditHistory], 1);
    }
}
