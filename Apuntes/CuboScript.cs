using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboScript : MonoBehaviour
{
    public GameObject e;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Cubo: Mi nombre es " + name);

        GameObject[] list = GameObject.FindGameObjectsWithTag("Esfera");

        Debug.Log("[CUBO] He encontrado " + list.Length + " elementos de tipo Esfera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
