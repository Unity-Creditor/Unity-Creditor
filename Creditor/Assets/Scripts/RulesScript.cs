using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulesScript : MonoBehaviour
{
  public int ScorePoint = 0;
  bool RightSwipe = true;
  public int localScore;

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
    }
  }
}
