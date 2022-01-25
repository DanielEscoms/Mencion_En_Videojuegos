using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    bool directionRight = true;
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
        yield return new WaitForSeconds(0.8f);
        MoveEnemy();
        StartCoroutine(Wait());
    }

    void MoveEnemy()
    {
        if (directionRight == true) {
            transform.Translate(Vector3.right);
            if (transform.position.x > 6.5)
            {
                directionRight = false;
            }
        }
        else {
            transform.Translate(Vector3.left);
            if (transform.position.x < -6.5)
            {
                directionRight = true;
            }
        }
    }
}
