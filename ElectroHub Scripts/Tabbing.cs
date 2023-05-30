using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Tabbing : MonoBehaviour
{
    public InputField UsernameInput;
    public InputField PasswordInput;
    public int InputSelected;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            InputSelected += 1;
            if (InputSelected > 1)
            {
                InputSelected = 0;
                
            }
            SelectInput();
        }
    }
    void SelectInput()
    {
        switch (InputSelected)
        {
            case 0: UsernameInput.Select();
                break;
            case 1: PasswordInput.Select();
                break ;
            
        }
    }
    public void UsernameSelected() => InputSelected = 0;
    public void EmailSelected() => InputSelected = 1;
}