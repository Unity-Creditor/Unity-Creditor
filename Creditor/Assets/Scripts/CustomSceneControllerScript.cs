using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CustomSceneControllerScript : Manager<CustomSceneControllerScript>
{
    public ArraysLayout ScenesItems;
    public Button[] StoreButtons = new Button[1];
    public Button[] StoreItemsButton = new Button[5];
    public GameObject[] ActiveObjects;
    public int[] ItemNumber = new int [13];

    public int Cost = 0;
    public int AddCoin = 100;
    public GameObject OthersButtons;
    public Vector3 StartButtonPosition = new Vector3(0, -710, 0);
    public TextMeshProUGUI Coins;

    public int ActivatedShop;
    int PreviousActivatedShop = -1;



    void Start()
    {
      //PlayerPrefs.SetInt("dollars", PlayerPrefs.GetInt("dollars", 0) + AddCoin);
      //PlayerPrefs.Save();

      for (int i = 0; i < ItemNumber.Length; i++)
      {
        ItemNumber[i] = PlayerPrefs.GetInt("ItemNumber" + i, 0);
      }

      Coins.text = "" + PlayerPrefs.GetInt("dollars");
      ActiveObjects = new GameObject[ScenesItems.rows.Length];
      for(int i = 0; i < ScenesItems.rows.Length; ++i)
      {
        ActiveObjects[i] = Instantiate(ScenesItems.rows[i].row[ItemNumber[i]]);
      }
      //Debug.Log(ScenesItems.rows[0].row[0]);
    }


    public void ChangeStore(int num = 0)
    {

      //Debug.Log(num + "" + ActivatedShop);
      StoreButtons[ActivatedShop].GetComponent<Image>().color = Color.white;
      StoreButtons[num].GetComponent<Image>().color = Color.gray;

      ActivatedShop = num;
      OthersButtons.SetActive(true);

    }


    public void ChangeActiveObject(int num = 0)
    {

      if ((ScenesItems.rows[ActivatedShop].row.Length - 1 >= num) && (ItemNumber[ActivatedShop] != num) && (PlayerPrefs.GetInt("dollars") - (num + 1) * Cost) >= 0)
      {
        Destroy(ActiveObjects[ActivatedShop]);
        ActiveObjects[ActivatedShop] = Instantiate(ScenesItems.rows[ActivatedShop].row[num]);

        PlayerPrefs.SetInt("dollars", PlayerPrefs.GetInt("dollars") - (num + 1) * Cost);
        PlayerPrefs.SetInt("ItemNumber" + ActivatedShop, num);

        Coins.text = "" + PlayerPrefs.GetInt("dollars");
        ItemNumber[ActivatedShop] = num;
      }
    }

}
