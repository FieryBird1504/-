using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public Sprite[] HPSprites;
    public Image HPHeart;

    public ball player;

    public void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").GetComponent<ball>();
    }

    public void Update()
    {
       // HPHeart.sprite = HPSprites[player.curHealth];
    }
    
}
