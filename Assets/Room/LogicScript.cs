using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public string[] Description;
    public void ShowDescription(int num)
    {
        Debug.Log(Description[num]);
    }
}