using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour
{
    GameObject spaceShip;
    SpaceShipScript scriptNave;
    
    // Start is called before the first frame update
    void Start()
    {
        spaceShip = GameObject.FindGameObjectWithTag("Player");
        scriptNave = spaceShip.GetComponent<SpaceShipScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) // aquí está el objeto contra el que choca, en este caso al poner el script en el torpedo el objeto será el TriggerTop (el gatillo superior)
    {
        Debug.Log("SHOT: He chocado con " + collision.gameObject.name);
        scriptNave.SetCanShot();
        Destroy(gameObject);
    }
}
