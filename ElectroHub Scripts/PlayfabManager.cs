using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEditor.PackageManager.Requests;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class PlayfabManager : MonoBehaviour {

    [Header("UI")]
    public Text messageText;
    public InputField emailInput;
    public InputField passwordInput;

    

    public void RegisterButton() {
        var request = new RegisterPlayFabUserRequest {
            Email = emailInput.text,
            Password = passwordInput.text,
            RequireBothUsernameAndEmail = false
        };
        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnError);
        Debug.Log("Register button pressed");
    }

    void OnRegisterSuccess(RegisterPlayFabUserResult result) {
        messageText.text = "Registered and Logged in!";
    }
    public void LoginButton() {
        var request = new LoginWithEmailAddressRequest {
            Email = emailInput.text,
            Password = passwordInput.text
        };
        PlayFabClientAPI.LoginWithEmailAddress(request, OnSuccess, OnError);
    
    }
    

    public void ResetPasswordButton() {
        var request = new SendAccountRecoveryEmailRequest {
            Email = emailInput.text,
            TitleId = "31011"
        };
        PlayFabClientAPI.SendAccountRecoveryEmail(request, OnPasswordReset, OnError);
    }
    void OnPasswordReset(SendAccountRecoveryEmailResult result) {
        messageText.text = "Password reset mail sent!";

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

   

    void OnSuccess(LoginResult result) {
        Debug.Log("Successful Login / Create!");
        SceneManager.LoadScene("Course selector");

    }

    void OnError(PlayFabError error) {
        Debug.Log("Error Whilst Logging in / Creating Account");
        Debug.Log(error.GenerateErrorReport());

        
    }
}
