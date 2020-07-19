using TMPro;
using UnityEngine;

public class RulesScript : Manager<RulesScript>
{
    public int ScorePoint = 0;
    bool RightSwipe = true;
    public int localScore;
    public GameObject winPanel;
    public GameObject scene;
    public TextMeshProUGUI score;

    private void Start()
    {
        EnderSCR.Instance.ChangeStars(ScorePoint);
        winPanel.SetActive(false);
        Debug.LogError("rule client");
    }
    /*public void StartCopy()
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
            score.text = ScorePoint.ToString();
            EnderSCR.Instance.ChangeStars(ScorePoint);
            if (ScorePoint>=EnderSCR.Instance.maxScore)
            {
                winPanel.SetActive(true);
                scene.SetActive(false);
            }
        }
    }
}
