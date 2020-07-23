using UnityEngine;

public class EnderSCR : MonoBehaviour
{
    public void End()
    {
        /*        if (PlayerPrefs.GetInt("isComplited") == 1)
                {
                    PlayerPrefs.SetInt("openedLevel", PlayerPrefs.GetInt("openedLevel") + 1);
                    PlayerPrefs.SetInt("localStars", FindObjectOfType<StarsSCR>().stars); 
                }
                else
                {
                    PlayerPrefs.SetInt("isComplited",1);
                    PlayerPrefs.SetInt("openedLevel", PlayerPrefs.GetInt("openedLevel") + 1);
                }*/
        if (PlayerPrefs.GetInt("currentLevel") == PlayerPrefs.GetInt("openedLevel"))
        {
            PlayerPrefs.SetInt("openedLevel", PlayerPrefs.GetInt("openedLevel") + 1);
        }
        GetComponent<AudioSource>().Play();
    }
}
