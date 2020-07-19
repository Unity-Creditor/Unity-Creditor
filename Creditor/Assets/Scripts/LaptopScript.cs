﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopScript : Manager<LaptopScript>
{
    public int ActualGraph;
    public GameObject[] ScreenArts =  new GameObject[3];

    void Start()
    {
        for (int i = 0; i != ScreenArts.Length; ++i)
        {
          ScreenArts[i].SetActive(false);
        }

        ScreenArts[0].SetActive(true);
    }

    public void ChangeGraph(int GraphControl)
    {
      if (GraphControl != ActualGraph)
      {
        ScreenArts[ActualGraph].SetActive(false);
        ActualGraph = GraphControl;
        ScreenArts[GraphControl].SetActive(true);
      }
    }
}
