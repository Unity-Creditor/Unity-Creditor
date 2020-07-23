using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStars : MonoBehaviour
{

    public GameObject[] stars;
    void Start()
    {
        //SetStars();
    }

    void Disabler()
    {
        foreach (var item in stars)
        {
            item.SetActive(false);
        }
    }
    public void SetStars()
    {
        Disabler();
        stars[GetComponentInParent<Loader>().localStars].SetActive(true);
    }

}
