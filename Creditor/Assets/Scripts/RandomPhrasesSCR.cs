using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomPhrasesSCR : MonoBehaviour
{
    public string[] phrases;
    public float timer = 10f;
    public GameObject cloud;
    TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = 10f;
            text.enabled = false;
/*            while (cloud.GetComponent<SpriteRenderer>().color.a > 0)
            {
                cloud.GetComponent<SpriteRenderer>().color -= new Color(cloud.GetComponent<SpriteRenderer>().color.r, cloud.GetComponent<SpriteRenderer>().color.g, cloud.GetComponent<SpriteRenderer>().color.b, 0.1f*Time.deltaTime);
                //yield return null;
            }*/
            text.text = phrases[Random.Range(0,phrases.Length)];
            text.enabled = true;
/*            while (cloud.GetComponent<SpriteRenderer>().color.a > 0)
            {
                cloud.GetComponent<SpriteRenderer>().color += new Color(cloud.GetComponent<SpriteRenderer>().color.r, cloud.GetComponent<SpriteRenderer>().color.g, cloud.GetComponent<SpriteRenderer>().color.b, 0.1f * Time.deltaTime);
                //yield return null;
            }*/
        }
    }
/*    void SetInVisble()
    {
        while (cloud.GetComponent<SpriteRenderer>().color.a>0)
        {
            cloud.GetComponent<SpriteRenderer>().color -= new Color(cloud.GetComponent<SpriteRenderer>().color.r, cloud.GetComponent<SpriteRenderer>().color.g, cloud.GetComponent<SpriteRenderer>().color.b,Time.deltaTime);
            //yield return null;
        }
        *//*StopCoroutine(SetInVisble());*//*
    }
    void SetVisble()
    {
        while (cloud.GetComponent<SpriteRenderer>().color.a>0)
        {
            cloud.GetComponent<SpriteRenderer>().color += new Color(cloud.GetComponent<SpriteRenderer>().color.r, cloud.GetComponent<SpriteRenderer>().color.g, cloud.GetComponent<SpriteRenderer>().color.b,Time.deltaTime);
            //yield return null;
        }
       *//* StopCoroutine(SetVisble());*//*
    }*/
}
