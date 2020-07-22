using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomSceneControllerScript : Manager<CustomSceneControllerScript>
{
    public ArraysLayout ScenesItems;
    public Button[] StoreButtons = new Button[1];
    public GameObject[] ActiveObjects;
    public Vector3 StartButtonPosition = new Vector3(0, -710, 0);
    public int ActivatedShop;
    public int[] ItemNumber = new int [13];

    void Start()
    {

      ActiveObjects = new GameObject[ScenesItems.rows.Length];

      for(int i = 0; i < ScenesItems.rows.Length; ++i)
      {
        ActiveObjects[i] = Instantiate(ScenesItems.rows[i].row[ItemNumber[i]]);
      }

      /*for (int i = 0; i < StoreButtons.Length; i++)
      {
        StoreButtons[i].onClick.AddListener( () => ChangeStore(i-1) );
      }*/
      //Debug.Log(ScenesItems.rows[0].row[0]);
    }

    public void ChangeStore(int num = 0)
    {

      Debug.Log(num + "" + ActivatedShop);
      StoreButtons[ActivatedShop].GetComponent<Image>().color = Color.white;
      StoreButtons[num].GetComponent<Image>().color = Color.cyan;

      ActivatedShop = num;

    }

    void Update()
    {

    }
}
