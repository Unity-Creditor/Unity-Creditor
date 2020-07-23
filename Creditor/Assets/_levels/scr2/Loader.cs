using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loader : MonoBehaviour
{
    public int loadScene;
    public int level;
    public bool levelButton = false;

    //public int currentLevel;
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
        //ClearLevel();
        //PlayerPrefs.SetInt("openedLevel", 1);
        if (levelButton)
        {
            //ClearLevel();
            if (PlayerPrefs.GetInt("currentLevel") == level)
            {
                localStars = PlayerPrefs.GetInt("localStars");
                GetComponentInChildren<LevelStars>().SetStars(localStars);
            }
            if (PlayerPrefs.GetInt("openedLevel") >= level)
            {
                GetComponent<Button>().interactable = true;
            }
            else
            {
                GetComponent<Button>().interactable = false;
            }
        }
    }

    public void ClearLevel()
    {
        PlayerPrefs.SetInt("maxScore", 0);
        PlayerPrefs.SetInt("creditType", 0);
        PlayerPrefs.SetInt("openedLevel", 1);
        PlayerPrefs.SetInt("isArcade", 0);
        PlayerPrefs.SetInt("creditHistory", 0);
        //PlayerPrefs.SetInt("localStars", 0);
        //PlayerPrefs.SetInt("localStars", stars);
        PlayerPrefs.SetInt("globalMans", 0);
        PlayerPrefs.SetInt("isComplited", 0);
        PlayerPrefs.SetInt("currentLevel", 1);
        //SceneManager.LoadScene(loadScene);
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
        //PlayerPrefs.SetInt("localStars", 0);
        //PlayerPrefs.SetInt("localStars", stars);
        PlayerPrefs.SetInt("globalMans", mans);
        PlayerPrefs.SetInt("isComplited", isComplited);
        PlayerPrefs.SetInt("currentLevel", level);
        SceneManager.LoadScene(loadScene);
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
