using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;

/*
 Порядок в файле:
    Nickname
*/
public class FileWork : MonoBehaviour {

    string FName = "Data/Save/Info.txt";
    List<string> FList = new List<string>();
    

    public void Start()
    {
    }

    public void Update()
    {
    }


    public List<string> FRead()
    {

        FList.Clear();

        StreamReader DataF = new StreamReader(FName);
        while (!DataF.EndOfStream)
        {
           FList.Add(DataF.ReadLine());
        }

        DataF.Close();
        return FList;
    }

    public void EnterNickname(string CharName)
    {
       StreamWriter DataF = new StreamWriter(FName);
        DataF.WriteLine(CharName);
        DataF.Close();
    }

    public bool IsFile(bool isCreat)
    {
        FileInfo DataF = new FileInfo(FName);
        if (DataF.Exists) return true;
        else
        {
            if(isCreat) DataF.Create();
            return false;
        }
    }       
    
    public void EnterChar(string Char)
    {
        FRead();
        
        if (FList.Count >= 2)
            {
                FList.RemoveAt(1);
                FList.Insert(1, Char);
            }
        else    FList.Add(Char);

        StreamWriter DataF = new StreamWriter(FName);
        for (int i=0; i<FList.Count; i++)
        {
            DataF.WriteLine(FList[i]);
        }
        DataF.Close();
    }
}
