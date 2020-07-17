using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    public int loadScene;

    public void LoadMyScene()
    {
        SceneManager.LoadScene(loadScene);
    }
}
