using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStars : MonoBehaviour
{

    public GameObject[] stars;
    void Start()
    {
        Disabler();
        stars[GetComponentInParent<Loader>().localStars].SetActive(true);
    }

    void Disabler()
    {
        foreach (var item in stars)
        {
            item.SetActive(false);
        }
    }   

}
