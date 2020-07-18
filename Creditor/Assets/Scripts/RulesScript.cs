using UnityEngine;
using TMPro;

public class RulesScript : Manager<RulesScript>
{
    public int ScorePoint = 0;
    bool RightSwipe = true;
    public int localScore;
    public TextMeshProUGUI score;

    void Start()
    {

    }


    public void RightSpriteFunc()
    {
        if (RightSwipe)
        {
            Debug.Log(localScore);
            //Debug.Log(localScore.ActualCreditHistory);
            ScorePoint += localScore - 2;
            score.text = ScorePoint.ToString();
        }
    }
}
