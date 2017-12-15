using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public GameObject pausePanel;

    public bool pause;



    public void Start()
    {
        pausePanel.SetActive(false);
        pause = false;
    }



    public void Update()
    {
        if(pause)
        {
            pausePanel.SetActive(true);
        }
        else
        {
            pausePanel.SetActive(false);
        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause = !pause;
        }
        
    }

    
   
}
