using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NextVisiter : MonoBehaviour
{
    public GameObject Visiter, Indicator;
    public Vector3 Spawn = Vector3.zero;
    public Vector3 actualPosition = new Vector3(0, 0.2f, 0);
    public Color[] CreditHistoryColor = new Color[3];

    //public float changeSpeed = 0.1f;

    int ActualCreditHistory;

    public void Start()
    {
      Invoke("NextClient", 0);
    }

    public void NextClient()
    {
      Indicator = GameObject.FindWithTag("Indicator");

      Debug.Log("Instantiate");
      var CreatedVisiter = Instantiate(Visiter, Spawn, Quaternion.identity);
      ActualCreditHistory = Random.Range(0, 3);

      Debug.Log("i изменился" + ActualCreditHistory);
      Debug.Log(Indicator.GetComponent<SpriteRenderer> ().color);
      Indicator.GetComponent<SpriteRenderer> ().color = Color.Lerp(Indicator.GetComponent<SpriteRenderer> ().color, CreditHistoryColor[ActualCreditHistory], 1);
      Debug.Log(Indicator.GetComponent<SpriteRenderer> ().color);
    }

}
