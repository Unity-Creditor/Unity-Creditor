using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loader : MonoBehaviour
{
    public int loadScene;
    public int level;

    public int currentLevel;
    public int maxScore = 2;
    public int creditType;
    public int isArcade;
    public int creditHistory;
    public int stars;
    public int mans;
    public int isComplited;
    public int localStars;

    private void Start()
    {
        //PlayerPrefs.SetInt("openedLevel", 1);

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
        PlayerPrefs.SetInt("maxScore", maxScore);
        PlayerPrefs.SetInt("creditType", creditType);
        PlayerPrefs.SetInt("isArcade", isArcade);
        PlayerPrefs.SetInt("creditHistory", creditHistory);
        PlayerPrefs.SetInt("stars", stars);
        //PlayerPrefs.SetInt("localStars", stars);
        PlayerPrefs.SetInt("mans", mans);
        PlayerPrefs.SetInt("isComplited",  isComplited);
        SceneManager.LoadScene(loadScene);
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
