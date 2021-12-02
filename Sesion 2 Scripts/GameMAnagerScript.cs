using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMAnagerScript : MonoBehaviour
{
    public GameObject myPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GameObject nuevaCarta = Instantiate(myPrefab, new Vector3(-8, 3, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
