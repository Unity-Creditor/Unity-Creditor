using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UndoButtonScript : MonoBehaviour
{
    Button Undo;

    void Start()
    {
      Undo = gameObject.GetComponent<Button>();
      Undo.onClick.AddListener(UndoFunction);
    }

    void UndoFunction()
    {
      SceneManager.LoadScene(0);
    }
}
