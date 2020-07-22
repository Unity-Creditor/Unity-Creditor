using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loader : MonoBehaviour
{
    public int loadScene;
    public int level;
    public int maxScore = 2;
    private void Start()
    {
        PlayerPrefs.SetInt("openedLevel", 1);
        if (PlayerPrefs.GetInt("openedLevel") >= level)
        {
            GetComponent<Button>().interactable = true;
        }
        else
        {
            GetComponent<Button>().interactable = false;
        }
    }

    public void LoadMyScene()
    {
        SceneManager.LoadScene(loadScene);
    }

    public void LoadLevel()
    {
        PlayerPrefs.SetInt("maxScore",20);
        SceneManager.LoadScene(loadScene);
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
