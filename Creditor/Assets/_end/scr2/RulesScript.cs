using TMPro;
using UnityEngine;

public class RulesScript : MonoBehaviour /*Manager<RulesScript>*/
{
    public int ScorePoint = 0;
    bool RightSwipe = true;
    public int localScore;
    public GameObject winPanel;
    public GameObject scene;
    public StarsSCR stars;
    public TextMeshProUGUI score;
    public LaptopScript laptop;
    public CreditHistorySCR creditHistory;
    public NextVisiter nextVisiter;
    public bool isEnd = false;
    public int rightMans = 0;
    public int mans = 0;


    private void Start()
    {
        winPanel = GameObject.FindGameObjectWithTag("winPanel");
        scene = GameObject.FindGameObjectWithTag("scene");
        stars = FindObjectOfType<StarsSCR>();
        laptop = FindObjectOfType<LaptopScript>();
        creditHistory = FindObjectOfType<CreditHistorySCR>();
        //winPanel.SetActive(false);
        nextVisiter = FindObjectOfType<NextVisiter>();
        //PlayerPrefs.SetInt("globalMans", 5);
    }
    /*public void AwakeCopy()
    {
        EnderSCR.Instance.ChangeStars(ScorePoint);
        winPanel.SetActive(false);
        Debug.LogError("kostili client");
    }*/
    public void RightSpriteFunc()
    {
        if (RightSwipe)
        {
            if (PlayerPrefs.GetInt("creditType") == 0 && PlayerPrefs.GetInt("creditHistory") == 0 ||
                PlayerPrefs.GetInt("creditType") == laptop.actualGraph && PlayerPrefs.GetInt("creditHistory")== creditHistory.actualHistory)
            {
                rightMans++;
                Debug.Log(rightMans);
                //Debug.Log(localScore.ActualCreditHistory);
                ScorePoint += localScore - 2;
                PlayerPrefs.SetInt("money", ScorePoint*100);
                //score.text = ScorePoint.ToString();
                if(PlayerPrefs.GetInt("isArcade")!=1) stars.ChangeStars(ScorePoint);
                if (PlayerPrefs.GetInt("isArcade")!=1 && rightMans >= stars.maxScore)
                {
                    winPanel.SetActive(true);
                    //GameObject.FindGameObjectWithTag("scene").SetActive(false);
                    FindObjectOfType<VisiterAwake>().gameObject.SetActive(false);
                    isEnd = true;
                }
            }
        }
    }
    public void SetLocalScore()
    {
        localScore = laptop.actualGraph + creditHistory.actualHistory;
        mans++;
        if (mans > PlayerPrefs.GetInt("globalMans") && PlayerPrefs.GetInt("isArcade")!=1) FindObjectOfType<StarsSCR>().EndVoid();
        Debug.Log(mans+" "+PlayerPrefs.GetInt("globalMans"));
    }
    public void ForTaskEnder()
    {
        isEnd = true;
    }
    public void ForTaskUnEnder()
    {
        isEnd = false;
    }
}
