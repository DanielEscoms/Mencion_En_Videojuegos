using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject e;
    
    // Start is called before the first frame update
    void Start()
    {
        e = GameObject.FindGameObjectWithTag("fighter");
        Debug.Log(e);
        Fighter fighter = e.GetComponent<Fighter>();
        Debug.Log("El nombre: " + fighter.Name);
        Debug.Log("La categoria: " + fighter.Category);
        Debug.Log("La vida: " + fighter.Health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
