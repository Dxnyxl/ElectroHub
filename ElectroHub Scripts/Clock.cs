using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;
using UnityEditor.PackageManager.Requests;
using System;

public class Clock : MonoBehaviour
{
    public Text Textbox;
    public float time;
    void Start()
    {
        time = ((float)DateTime.Now.Hour + ((float)DateTime.Now.Minute * 0.01f));
        DisplayTime();
    }

    void DisplayTime()
    {
        Textbox.text = (24 - time).ToString();
    }
}
