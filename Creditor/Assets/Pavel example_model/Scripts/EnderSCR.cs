using UnityEngine.UI;

public class EnderSCR : Manager<EnderSCR>
{
    public int maxScore;
    public Image[] images;

    // Start is called before the first frame update
    void Start()
    {
        ImageDisabler();
    }

    // Update is called once per frame
    void Update()
    {

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
        if (score < maxScore / 5 * 1)
        {
            ImageDisabler();
            images[1].gameObject.SetActive(true);
        }
        if (score > maxScore / 5 * 1 && score < maxScore / 5 * 2)
        {
            ImageDisabler();
            images[2].gameObject.SetActive(true);
        }
        if (score > maxScore / 5 * 2 && score < maxScore / 5 * 3)
        {
            ImageDisabler();
            images[3].gameObject.SetActive(true);
        }
        if (score > maxScore / 5 * 3 && score < maxScore / 5 * 5-1)
        {
            ImageDisabler();
            images[4].gameObject.SetActive(true);
        }
        if (/*score > maxScore / 5 * 4 &&*/score == maxScore / 5 * 5)
        {
            ImageDisabler();
            images[5].gameObject.SetActive(true);
        }
    }
}
