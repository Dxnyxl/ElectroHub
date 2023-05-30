using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;
using UnityEditor.PackageManager.Requests;


public class Scoremanager : MonoBehaviour
{
    public Text CoinText;
    public int Coins;
    public bool CanAdd;

    void Start()
    {
        CanAdd = true;
        GetCurrency();
        
        
    }
    public void AddPoint()
    {
        if (CanAdd == true)
        {
        GrantVirtualCurrency();
        
        
        CanAdd = false;
        FindObjectOfType<Questions>().NextQuestion();

        }
        
        


    }
    public void GrantVirtualCurrency()
    {
        var request = new AddUserVirtualCurrencyRequest {
            VirtualCurrency = "CN",
            Amount = 1
        };
        PlayFabClientAPI.AddUserVirtualCurrency(request, OnGrantVirtualCurrencySuccess, OnError);
    }
    void OnGrantVirtualCurrencySuccess(ModifyUserVirtualCurrencyResult result)
    {
        Debug.Log("Currency added");
        GetCurrency();
    }


    public void GetCurrency()
    {
        PlayFabClientAPI.GetUserInventory(new GetUserInventoryRequest(), OnGetUserInventorySuccess, OnError);
    }
    void OnGetUserInventorySuccess(GetUserInventoryResult result)
    {
        int coins = result.VirtualCurrency["CN"];
        CoinText.text = coins.ToString();
    }
    void OnError(PlayFabError error)
    {
        Debug.Log(error.ErrorMessage);
    }
    public void Flag()
    {
        CanAdd = true;
    }
}
