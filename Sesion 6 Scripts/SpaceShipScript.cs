using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipScript : MonoBehaviour
{
    public int force;
    public int forceTorpedo;
    Rigidbody2D myRB;
    public GameObject torpedo;
    bool canShot = true;
    
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movement = Input.GetAxis("Horizontal");

        myRB.velocity = transform.right * movement * force;

        float xPos = Mathf.Clamp(transform.position.x, -6.5f, 6.5f);

        transform.position = new Vector2(xPos, transform.position.y);

        if (Input.GetButton("Jump") && canShot)
        {
            Vector2 posTorpedo = new Vector2(transform.position.x, transform.position.y +1.5f);
            GameObject clone = Instantiate(torpedo, posTorpedo, Quaternion.identity);

            Rigidbody2D cloneRB = clone.GetComponent<Rigidbody2D>();

            Vector2 direccion = new Vector2(0f, 1f); 

            cloneRB.velocity = direccion * forceTorpedo;

            canShot = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Nave: Collision");
    }

    public void SetCanShot()
    {
        canShot = true;
    }
}
