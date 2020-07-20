using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine;

public class EnderSCR : MonoBehaviour /*Manager<EnderSCR>*/
{
    public int maxScore = 20;
    public Image[] images;
    public int part;
    public UnityEvent end;

    void Awake()
    {
        ImageDisabler();
        //part = maxScore / images.Length;
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
        if (score < maxScore / part * 1)
        {
            ImageDisabler();
            images[0].gameObject.SetActive(true);
        }
        if (score > part * 1 && score < part * 2)
        {
            ImageDisabler();
            images[1].gameObject.SetActive(true);
        }
        if (score > part * 2 && score < part * 3)
        {
            ImageDisabler();
            images[2].gameObject.SetActive(true);
        }
        if (score > part * 3 && score < maxScore-1)
        {
            ImageDisabler();
            images[3].gameObject.SetActive(true);
        }
        if (/*score > maxScore / 5 * 4 &&*/score >= maxScore)
        {
            ImageDisabler();
            images[4].gameObject.SetActive(true);
            end.Invoke();
        }
    }
}
