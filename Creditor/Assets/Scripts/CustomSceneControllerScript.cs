using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomSceneControllerScript : MonoBehaviour
{
    public ArraysLayout ScenesItems;
    public int[] ItemNumber = new int [13];
    //public  GameObject[,] faces, bodies, eyes, mouth, hairstyles, ties, computers, cup, books, tables, armchair, background;


    void Start()
    {
      //Debug.Log(ScenesItems.rows[0].row[0]);
      for(int i = 0; i < ScenesItems.rows.Length; ++i)
      {
        Instantiate(ScenesItems.rows[i].row[ItemNumber[i]]);

      }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
