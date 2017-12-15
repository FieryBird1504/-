using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterNickname : MonoBehaviour {

    public GameObject OldPanel, NewPanel;
    public InputField inputF;
    public Button AppBut;
    string CheckText;
   
    
    public string Nickname;

    void Start()
    {
        CheckText = inputF.textComponent.text;
    }

    public void CheckButton()
    {
        if (inputF.textComponent.text != CheckText) 
            AppBut.interactable = true;
        else AppBut.interactable = false;
    }

    public void ButtonApply()
    {
        Nickname = inputF.textComponent.text;
        OldPanel.SetActive(false);
        NewPanel.SetActive(true);
        
    }
}

