using UnityEngine;

public class PlayerSCR : MonoBehaviour
{
    public AudioSource yes;
    public AudioSource no;

    public void PlayYes()
    {
        yes.Play();
    }
    public void PlayNo()
    {
        no.Play();
    }
}
