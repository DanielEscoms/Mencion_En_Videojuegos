﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D myRB;
    public float speed;
    //GameObject player;
    bool faceRight = true;
    SpriteRenderer myRenderer;
    Animator myAnim;
    
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        // player = GameObject.FindGameObjectWithTag("Player");
        myRenderer = GetComponent<SpriteRenderer>();
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        
        if (move > 0 && !faceRight)
        {
            // player.GetComponent<SpriteRenderer>().flipX = false;
            Turn();
        }
        else
        {
            if (move < 0 && faceRight)
            {
                // player.GetComponent<SpriteRenderer>().flipX = true;
                Turn();
            }
        }

        myRB.velocity = new Vector2(move * speed, myRB.velocity.y);
        myAnim.SetFloat("MoveSpeed", Mathf.Abs(move));
    }

    private void Turn()
    {
        myRenderer.flipX = !myRenderer.flipX;
        faceRight = !faceRight;
    }
}
