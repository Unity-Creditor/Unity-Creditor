using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UndoButtonScript : MonoBehaviour
{
    Button Undo;
    public GameObject UndoUI, ThisUI;

    void Start()
    {
      Undo = gameObject.GetComponent<Button>();
      Undo.onClick.AddListener(UndoFunction);
    }

    void UndoFunction()
    {
      UndoUI.SetActive(true);
      ThisUI.SetActive(false);
      //SceneManager.LoadScene(0);
    }
}
