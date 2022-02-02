using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    bool inGame = true;
    GameObject spaceHorda;
    HordaScript scriptHorda;

    // Start is called before the first frame update
    void Start()
    {
        spaceHorda = GameObject.FindGameObjectWithTag("Horda");
        scriptHorda = spaceHorda.GetComponent<HordaScript>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Torpedo")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
            scriptHorda.inGame = false;
        }
        
    }

}
