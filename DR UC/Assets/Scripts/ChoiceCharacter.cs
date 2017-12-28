using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChoiceCharacter : MonoBehaviour {

    public Button Button_Last, Button_Next;
    public Text CharName;
    public string[] ChName = new string[0];
    public GameObject[] ChPanel = new GameObject [0];
    int num;
    public FileWork FW;

    /*
    public struct ch
    {
        string name;
        GameObject panel;

        ch(string Name, GameObject Panel)
        {
            this.name = Name;
            this.panel = Panel;
        }
    }
    public ch[] MasCh = new ch[1];
    */

    void Start()
    {
        num = ChPanel.Length-1;
        ChangeCh(true);
    }


    public void ChangeCh(bool next)
    {
        ChPanel[num].SetActive(false);
        if (next)
                num++;
        else    num--;

        if (num == ChPanel.Length)
            num = 0;
        if (num == -1)
            num = ChPanel.Length - 1;


        ChPanel[num].SetActive(true);
        CharName.text = ChName[num];
    }

    public void Button_Start()
    {
        FW.EnterChar(CharName.text);
        SceneManager.LoadScene(2);
    }
}
