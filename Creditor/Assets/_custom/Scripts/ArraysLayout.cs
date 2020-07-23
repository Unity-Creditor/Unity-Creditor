using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]


//Этот скрипт позволяет создавать таблицы
public class ArraysLayout
{
  [System.Serializable]
  public struct rowData
  {
    public GameObject[] row;
  }

  public rowData[] rows = new rowData[5];
}
