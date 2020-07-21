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
    public bool isEnd = false;

    private void Awake()
    {
    }
    private void Start()
    {
        winPanel = GameObject.FindGameObjectWithTag("winPanel");
        scene = GameObject.FindGameObjectWithTag("scene");
        stars = FindObjectOfType<StarsSCR>();
        laptop = FindObjectOfType<LaptopScript>();
        creditHistory = FindObjectOfType<CreditHistorySCR>();
        winPanel.SetActive(false);

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
    public void SetLocalScore()
    {
        localScore = laptop.actualGraph + creditHistory.actualHistory;
    }
}
