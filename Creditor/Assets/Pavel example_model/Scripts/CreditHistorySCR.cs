using UnityEngine;

public class CreditHistorySCR : Manager<CreditHistorySCR>
{
    public int actualHistory;

    public GameObject _0;
    public GameObject _1;
    public GameObject _2;
    public GameObject _3;

    private void Awake()
    {
        _0.SetActive(false);
        _1.SetActive(false);
        _2.SetActive(false);
        _3.SetActive(false);
        //SetHistory()
    }
    public void SetHistory(int quality)
    {
        actualHistory = quality;
        if (quality == 0)
        {
            _0.SetActive(true);
            _1.SetActive(false);
            _2.SetActive(false);
            _3.SetActive(false);
        }
        if (quality == 1)
        {
            _0.SetActive(false);
            _1.SetActive(true);
            _2.SetActive(false);
            _3.SetActive(false);
        }
        if (quality == 2)
        {
            _0.SetActive(false);
            _1.SetActive(false);
            _2.SetActive(true);
            _3.SetActive(false);
        }
        if (quality == 3)
        {
            _0.SetActive(false);
            _1.SetActive(false);
            _2.SetActive(false);
            _3.SetActive(true);
        }
    }
}
