using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    bool directionRight = true;
    float sleep = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("MoveEnemy", 0.5f, 0.5f); // Llama a la función MoveEnemy, a los 0,5sec y vuelve a llarmarla a los 0.5sec
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(sleep);
        MoveEnemy();
        StartCoroutine(Wait());
    }

    void MoveEnemy()
    {
        if (directionRight) {
            
            if (transform.position.x > 5.5)
            {
                sleep -= 0.05f;
                directionRight = false;
                transform.Translate(Vector3.down);
            }
            else
            {
                transform.Translate(Vector3.right);
            }
        }
        else {
            
            if (transform.position.x < -5.5)
            {
                sleep -= 0.05f; 
                directionRight = true;
                transform.Translate(Vector3.down);
            }
            else
            {
                transform.Translate(Vector3.left);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Torpedo")
        {
            Destroy(gameObject);
        }
        
    }

}
