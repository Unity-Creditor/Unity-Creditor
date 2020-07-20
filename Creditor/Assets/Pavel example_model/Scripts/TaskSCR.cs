using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TaskSCR : Manager<TaskSCR>
{
    Image image;
    public Image buttonImage;
    public float visibleSpeed;
    public GameObject scene;
    public GameObject winPanel;
    public GameObject visiter;
    public bool isTask;

    void Awake()
    {
        image = GetComponent<Image>();
/*        image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);*/
        isTask = true;
        buttonImage = GetComponentInChildren<Image>();
        buttonImage.color = new Color(buttonImage.color.r, buttonImage.color.g, buttonImage.color.b, 0f);
        winPanel.SetActive(false);
        scene.SetActive(false);

        StartCoroutine(makeVisible());
    }

    public void AwakeMakeVisible()
    {
        scene.SetActive(false);

        buttonImage.gameObject.SetActive(true);
        if (FindObjectOfType<VisiterAwake>())
        {
            visiter = FindObjectOfType<VisiterAwake>().gameObject;
            visiter.SetActive(false);
        }

        //image.gameObject.SetActive(true);
        // StartCoroutine(makeVisible());
    }

    IEnumerator makeVisible()
    {

        while (image.color.a<=1f)
        {
            image.color += new Color(0, 0, 0, visibleSpeed * Time.deltaTime);
            buttonImage.color += new Color(0, 0, 0, visibleSpeed * Time.deltaTime);
            yield return null;


        }
        //StopCoroutine(makeVisible());
    }

    public void AwakeMakeInvisible()
    {
        buttonImage.gameObject.SetActive(false);
        //image.gameObject.SetActive(false);
        scene.SetActive(true);
        visiter.SetActive(true);
        //AwakeCoroutine(makeInvisible());
        /*        FindObjectOfType<VisiterAwake>().gameObject.SetActive(true);*/

    }

    IEnumerator makeInvisible()
    {

        while (image.color.a >= 0f)
        {
            image.color -= new Color(0, 0, 0, visibleSpeed * Time.deltaTime);
            buttonImage.color -= new Color(0, 0, 0, visibleSpeed * Time.deltaTime);
            yield return null;


        }
        //StopCoroutine(makeInvisible());
    }
}
