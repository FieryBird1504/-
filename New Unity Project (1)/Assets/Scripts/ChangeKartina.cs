using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeKartina : MonoBehaviour {

    public GameObject kartina1_1;
    public GameObject kartina1_2;
    bool sc = true;
    
    public void SetKartina()
    {
      
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player" && Input.GetKey(KeyCode.F))
        {
            Debug.Log("ItWork");
            if(sc)
            {
                kartina1_1.SetActive(false);
                kartina1_2.SetActive(true);
                sc = false;
            }
            else
            {
                kartina1_2.SetActive(false);
                kartina1_1.SetActive(true);
                sc = true;
            }
            
        }
    }
}
