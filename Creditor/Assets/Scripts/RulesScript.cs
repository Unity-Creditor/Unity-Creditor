using UnityEngine;
using UnityEngine.UI;

public class RulesScript : Manager<RulesScript>
{
    public int ScorePoint = 0;
    bool RightSwipe = true;
    public int localScore;
    public Text score;

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
            score.text = "Score: " + ScorePoint;
        }
    }
}
