﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    SpriteRenderer myRenderer;
    public Sprite front;
    public Sprite back;
    bool faceUp = false;
    //GameObject myGameManager;
    GameManagerScript myGameMAnagerScript;
    public int tipo;
    
    private void Awake()
    {
        myRenderer = GetComponent<SpriteRenderer>();
        //myGameManager = GameObject.FindGameObjectWithTag("GameController");
        myGameMAnagerScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManagerScript>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    private void OnMouseDown()
    {
        myGameMAnagerScript.ClickOnCard(tipo);

        if (!faceUp)
        {
            myRenderer.sprite = front;
        }
        else
        {
            myRenderer.sprite = back;
        }

        faceUp = !faceUp;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
