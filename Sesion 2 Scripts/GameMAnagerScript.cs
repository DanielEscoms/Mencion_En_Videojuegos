using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMAnagerScript : MonoBehaviour
{
    public GameObject myPrefab;
    List<GameObject> cardList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        float posX = -8;
        float posY = 3;

        for (int i=1; i < 11; i++)
        {
            GameObject nueva_carta = Instantiate(myPrefab, new Vector3(posX, posY, 0), Quaternion.identity);
            nueva_carta.name = "Carta" + i;
            cardList.Add(nueva_carta);

            posX += 3;
            if (i == 5) {
                posX = -8;
                posY = -3;
            }
            
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
