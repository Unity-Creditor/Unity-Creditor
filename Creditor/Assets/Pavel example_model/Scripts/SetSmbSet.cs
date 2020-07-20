using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSmbSet : MonoBehaviour
{
    public string name;
    public void ChoseSet(int value)
    {
        PlayerPrefs.SetInt(name, value);
    }
}
