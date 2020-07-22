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

                Debug.Log(localScore);
                //Debug.Log(localScore.ActualCreditHistory);
                ScorePoint += localScore - 2;
                //score.text = ScorePoint.ToString();
                stars.ChangeStars(ScorePoint);
                if (ScorePoint >= stars.maxScore)
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
