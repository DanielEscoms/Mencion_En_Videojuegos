using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D myRB;
    public float speed;
    GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        myRB.velocity = new Vector2(move * speed, myRB.velocity.y);
        if(move < 0)
        {
            player.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (move > 0)
        {
            player.GetComponent<SpriteRenderer>().flipX = false;
        }

    }
}
