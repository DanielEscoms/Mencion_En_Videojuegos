using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject myPrefab;
    List<GameObject> cardList = new List<GameObject>();
    public List<Sprite> faces;
    int[] contador = { 0, 0, 0, 0, 0 };
    int[] tipos = { 7, 1, 0, 9, 6 };
    
    // Start is called before the first frame update
    void Start()
    {
        float posX = -6;
        float posY = 2;

        GameObject nueva_carta;

        for (int i = 0; i < 10; i++)
        {
            nueva_carta = Instantiate(myPrefab, new Vector3(posX, posY, 0), Quaternion.identity);
            nueva_carta.name = "Carta" + i;

            bool encontrado = false;
            int pos = 0;
            while (!encontrado)
            {
                pos = Random.Range(0, 5);
                if (contador[pos] < 2)
                {
                    contador[pos] += 1;
                    encontrado = true;
                }
            }

            nueva_carta.GetComponent<CardScript>().front = faces[pos];
            nueva_carta.GetComponent<CardScript>().tipo = tipos[pos];

            cardList.Add(nueva_carta);

            posX += 3;
            if (i == 4)
            {
                posX = -6;
                posY = -2;
            }
        }
    }

    public void ClickOnCard(int t)
    {
        Debug.Log("He hecho click on card."+t);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
