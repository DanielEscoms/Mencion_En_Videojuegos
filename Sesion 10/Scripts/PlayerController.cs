using System;
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
    public float jumpForce;
    bool isGrounded = true;

    
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        // player = GameObject.FindGameObjectWithTag("Player");
        myRenderer = GetComponent<SpriteRenderer>();
        myAnim = GetComponent<Animator>();
        Physics2D.queriesStartInColliders = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myAnim.SetFloat("VerticalVelocity", myRB.velocity.y);

        if (Input.GetAxis("Jump") > 0 && isGrounded == true)
        {
            myRB.velocity = new Vector2(myRB.velocity.x, 0);
            myRB.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isGrounded = false;
            myAnim.SetBool("IsGrounded", false);
        }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);

        // If it hits something...
        if (hit.collider != null && isGrounded == false && myRB.velocity.y < 0 && hit.collider.gameObject.tag == "Floor")
        {
            if (hit.distance < 0.4)
            {
                Debug.Log("Detecto un objeto " + hit.collider.gameObject.name + " a distancia " + hit.distance);
                isGrounded = true;
                myAnim.SetBool("IsGrounded", true);
            }
        }
        
        
        float move = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Jump");
        
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
        //myRB.velocity = new Vector2(move * speed, moveVertical * speed);
        myAnim.SetFloat("MoveSpeed", Mathf.Abs(move));
        //myAnim.SetFloat("VerticalVelocity", Mathf.Abs(moveVertical));

        /*if (moveVertical > 0 && myAnim.GetBool("IsGrounded")==true)
        {
            myAnim.SetBool("IsGrounded", false);
        }
        else
        {
            if (moveVertical == 0 && myAnim.GetBool("IsGrounded")==false)
            {
                myAnim.SetBool("IsGrounded", true);
            }
        }*/
    }

    private void Turn()
    {
        myRenderer.flipX = !myRenderer.flipX;
        faceRight = !faceRight;
    }
}
