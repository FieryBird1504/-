using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    public GameObject stats;
    public GameObject options;
    public GameObject exit;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Starts()
    {
        SceneManager.LoadScene(2);
    }

    public void Stats()
    {

    }

    public void Options()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }


    public void ShowStats()
    {
        stats.SetActive(true);
    }

    public void ShowOptions()
    {
        options.SetActive(true);
    }

    public void ShowExit()
    {
        exit.SetActive(true);
    }
}
