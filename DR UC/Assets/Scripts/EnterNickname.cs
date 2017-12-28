using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class EnterNickname : MonoBehaviour {

    public GameObject Panel_MainMenu, Panel_EnterNickname;
    public InputField inputF;
    public Button AppBut;
    string CheckText;
    public FileWork FW;
    
    public string Nickname;

    void Start()
    {
        CheckText = inputF.textComponent.text;
        Debug.Log("EnterNickname Start");
        if (FW.IsFile(true)) Panel_MainMenu.SetActive(true);
            else
            {
                Panel_EnterNickname.SetActive(true);
                 Debug.Log("EnterNickname Start");

                
            }
        Debug.Log("EnterNickname Start");
    }

    public void CheckButton()
    {
        if (inputF.textComponent.text != CheckText) 
            AppBut.interactable = true;
        else AppBut.interactable = false;
    }

    public void ButtonApply()
    {
        FW.EnterNickname(inputF.textComponent.text);
        Panel_EnterNickname.SetActive(false);
        Panel_MainMenu.SetActive(true);
        
    }
}

