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
    public bool isTask;
    void Start()
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

    public void StartMakeVisible()
    {
        scene.SetActive(false);

        buttonImage.gameObject.SetActive(true);
        FindObjectOfType<VisiterAwake>().gameObject.SetActive(false);
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

    public void StartMakeInvisible()
    {
        buttonImage.gameObject.SetActive(false);
        //image.gameObject.SetActive(false);
        scene.SetActive(true);
        //StartCoroutine(makeInvisible());
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
