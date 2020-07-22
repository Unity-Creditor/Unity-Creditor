using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevelSCR : MonoBehaviour
{
    public GameObject gameManager;
    void Start()
    {
        Instantiate(gameManager,transform);
    }

}
