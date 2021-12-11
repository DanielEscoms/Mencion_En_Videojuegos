using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject myPrefab;
    List<GameObject> cardList = new List<GameObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        float posX = -7;
        float posY = 3;

        GameObject nueva_carta;

        for (int i = 1; i < 11; i++)
        {
            nueva_carta = Instantiate(myPrefab, new Vector3(posX, posY, 0), Quaternion.identity);
            nueva_carta.name = "Carta" + i;
            cardList.Add(nueva_carta);

            posX += 3;
            if (i == 5)
            {
                posX = -7;
                posY = -3;
            }


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
