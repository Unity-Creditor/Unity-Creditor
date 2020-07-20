using TMPro;
using UnityEngine;

public class RulesScript : Manager<RulesScript>
{
    public int ScorePoint = 0;
    bool RightSwipe = true;
    public int localScore;
    public TextMeshProUGUI score;

    private void Start()
    {
        EnderSCR.Instance.ChangeStars(ScorePoint);

    }
    public void RightSpriteFunc()
    {
        if (RightSwipe)
        {
            Debug.Log(localScore);
            //Debug.Log(localScore.ActualCreditHistory);
            ScorePoint += localScore - 2;
            score.text = ScorePoint.ToString();
            EnderSCR.Instance.ChangeStars(ScorePoint);
        }
    }
}
