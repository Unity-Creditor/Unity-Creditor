using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStars : MonoBehaviour
{

    public GameObject[] stars;
    public GameObject parent;
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
        stars[parent.GetComponent<Loader>().localStars].SetActive(true);
    }

}
