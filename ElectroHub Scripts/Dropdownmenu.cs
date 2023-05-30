using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using PlayFab;
using PlayFab.ClientModels;
using UnityEditor.PackageManager.Requests;

public class Dropdownmenu : MonoBehaviour
{
    public TMPro.TMP_Dropdown MenuSelector;

    public void Menu()
    {
        if (MenuSelector.value == 0)
        {
            SceneManager.LoadScene("Profile");
        }
        if (MenuSelector.value == 1)
        {
            SceneManager.LoadScene("HelpCentre");
        }
        if  (MenuSelector.value == 2)
        {
            PlayFabClientAPI.ForgetAllCredentials();
            SceneManager.LoadScene("Login Screen");
            
        }
    }

}
