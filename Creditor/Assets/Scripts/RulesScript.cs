using TMPro;
using UnityEngine;

public class RulesScript : MonoBehaviour /*Manager<RulesScript>*/
{
    public int ScorePoint = 0;
    bool RightSwipe = true;
    public int localScore;
    public GameObject winPanel;
    public GameObject scene;
    EnderSCR ender;
    public TextMeshProUGUI score;

    private void Awake()
    {
        winPanel = GameObject.FindGameObjectWithTag("winPanel");
        scene = GameObject.FindGameObjectWithTag("scene");

    }
    private void Start()
    {
        winPanel.SetActive(false);
        ender = FindObjectOfType<EnderSCR>();

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
            ender.ChangeStars(ScorePoint);
            if (ScorePoint >= ender.maxScore)
            {
                winPanel.SetActive(true);
                scene.SetActive(false);
            }
        }
    }
}
