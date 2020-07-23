using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreItemsButtonScript : MonoBehaviour
{
    public int TabNumber = 0;
    Button ThisButton;
    Color ColorOfThisButton;

    void Start()
    {
      ThisButton = gameObject.GetComponent<Button>();
      ThisButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
      CustomSceneControllerScript.Instance.ChangeActiveObject(TabNumber);
    }
}
