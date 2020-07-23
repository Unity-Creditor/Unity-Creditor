using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class StarsSCR : MonoBehaviour /*Manager<EnderSCR>*/
{
    public int maxScore = 20;
    public Image[] images;
    public int part;
    public UnityEvent end;
    public int stars = 0;

    private void Awake()
    {
        maxScore = PlayerPrefs.GetInt("globalMans");
        part = maxScore / images.Length;
    }
    void Start()
    {
        //PlayerPrefs.SetInt("isArcade", 0);
        if (PlayerPrefs.GetInt("isArcade") == 1) gameObject.SetActive(false);
        //maxScore = PlayerPrefs.GetInt("maxScore");
        ImageDisabler();
    }

    void ImageDisabler()
    {
        foreach (Image i in images)
        {
            i.gameObject.SetActive(false);
        }
    }

    public void ChangeStars(int score)
    {
        Debug.Log(PlayerPrefs.GetInt("isArcade"));
        if (PlayerPrefs.GetInt("isArcade") != 1)
        {
            if (score < maxScore / part * 1)
            {
                ImageDisabler();
                PlayerPrefs.SetInt("localStars", 0);
                images[0].gameObject.SetActive(true);
            }
            if (score > part * 1 && score < part * 2)
            {
                ImageDisabler();
                PlayerPrefs.SetInt("localStars", 1);
                images[1].gameObject.SetActive(true);
            }
            if (score > part * 2 && score < part * 3)
            {
                ImageDisabler();
                PlayerPrefs.SetInt("localStars", 2);
                images[2].gameObject.SetActive(true);
            }
            if (score > part * 3 && score < maxScore - 1)
            {
                ImageDisabler();
                PlayerPrefs.SetInt("localStars", 2);
                images[2].gameObject.SetActive(true);
            }
            if (/*score > maxScore / 5 * 4 &&*/score >= maxScore)
            {
                ImageDisabler();
                PlayerPrefs.SetInt("localStars", 3);
                images[3].gameObject.SetActive(true);
                end.Invoke();
            }

        }
    }
    public void EndVoid()
    {
        end.Invoke();
    }
}
