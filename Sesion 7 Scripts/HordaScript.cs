using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HordaScript : MonoBehaviour
{
    bool directionRight = true;
    float sleep = 0.8f;
    public bool inGame = true;
    public int contador = 0;

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
        if (inGame)
        {
            MoveEnemy();
        }
        StartCoroutine(Wait());
    }

    void MoveEnemy()
    {
        if (directionRight)
        {

            if (transform.position.x > 4)
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
        else
        {

            if (transform.position.x < -4)
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
}
