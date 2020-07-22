using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomSceneControllerScript : Manager<CustomSceneControllerScript>
{
    public ArraysLayout ScenesItems;
    public Button[] StoreButtons = new Button[1];
    public Button[] StoreItemsButton = new Button[5];
    public GameObject[] ActiveObjects;
    public Vector3 StartButtonPosition = new Vector3(0, -710, 0);

    public int ActivatedShop;
    int PreviousActivatedShop = -1;

    public int[] ItemNumber = new int [13];


    void Start()
    {

      ActiveObjects = new GameObject[ScenesItems.rows.Length];
      for(int i = 0; i < ScenesItems.rows.Length; ++i)
      {
        ActiveObjects[i] = Instantiate(ScenesItems.rows[i].row[ItemNumber[i]]);
      }
      //Debug.Log(ScenesItems.rows[0].row[0]);
    }


    public void ChangeStore(int num = 0)
    {

      Debug.Log(num + "" + ActivatedShop);
      StoreButtons[ActivatedShop].GetComponent<Image>().color = Color.white;
      StoreButtons[num].GetComponent<Image>().color = Color.gray;

      ActivatedShop = num;

    }


    public void ChangeActiveObject(int num = 0)
    {

      if (ScenesItems.rows[ActivatedShop].row.Length - 1 >= num)
      {
        Destroy(ActiveObjects[ActivatedShop]);
        ActiveObjects[ActivatedShop] = Instantiate(ScenesItems.rows[ActivatedShop].row[num]);
        ItemNumber[ActivatedShop] = num;
      }

/*      try
      {
        Destroy(ActiveObjects[ActivatedShop]);
        ActiveObjects[ActivatedShop] = Instantiate(ScenesItems.rows[ActivatedShop].row[num]);
        ItemNumber[ActivatedShop] = num;
      }
      catch (Exception e)
      {
        Debug.Log("nnn");
      }*/
    }


    /*void Update()
    {
      if (PreviousActivatedShop != ActivatedShop)
      {
        for (int i = 0; i < StoreItemsButton.Length; i++)
        {

        }
      }
    }*/
}
