using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSmbSet : MonoBehaviour
{
    public string name;
    public bool isBuyed = false;
    public GameObject chice;
    public void ChoseSet(int value)
    {
        if(isBuyed) PlayerPrefs.SetInt(name, value);
        //else choice
    }
}
