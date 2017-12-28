using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour {

    bool OnFlor = true;
    public GameObject furn;
    public GameObject coll1_1;
    public GameObject coll1_2;
    Vector2 pos;

    void OnTriggerStay2D(Collider2D other)
    {
        
        if (other.tag == "Player" && Input.GetKey(KeyCode.Space))
            if(OnFlor)
            {
                Debug.Log("ItWork");
                coll1_1.SetActive(false);
                coll1_2.SetActive(true);
                other.transform.position = furn.transform.position;
                OnFlor = false;
            
            }
            else
            {
                Debug.Log("ItWork");
                coll1_1.SetActive(true);
                coll1_2.SetActive(false);

                OnFlor = true;
            }
            
    }           
    
}
