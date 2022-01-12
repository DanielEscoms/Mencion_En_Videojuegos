using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public GameObject myPrefab;
    public GameObject texto;
    List<GameObject> cardList = new List<GameObject>();
    public List<Sprite> faces;
    int[] contador = { 0, 0, 0, 0, 0 };
    int[] tipos = { 7, 1, 0, 9, 6 };
    int state = 1;
    int cardUp, cardUpIndex;
    int numParejas = 0;
    
    
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
            nueva_carta.GetComponent<CardScript>().index = i;

            cardList.Add(nueva_carta);

            posX += 3;
            if (i == 4)
            {
                posX = -6;
                posY = -2;
            }
        }

        texto.GetComponent<Text>().text = "Num Parejas: 0";
    }

    public void ClickOnCard(int t, int index)
    {
        Debug.Log("He hecho click on card."+t);

        if (state == 1)
        {
            cardUp = t;
            cardUpIndex = index;
            state = 2;
        }
        else 
        {
            if(t== cardUp)
            {
                Debug.Log("Ha salido pareja");
                cardList[index].SetActive(false);
                cardList[cardUpIndex].SetActive(false);
                numParejas++;
                texto.GetComponent<Text>().text = "Num parejas: " + numParejas;
            }
            else
            {
                Debug.Log("No hay pareja");
                StartCoroutine(WaitAndPrint(index));
                Debug.Log("No hay pareja después del Wait");
            }
            state = 1;
        }
    }

    IEnumerator WaitAndPrint(int i)
    {
        Debug.Log("Antes del waitforseconds");
        yield return new WaitForSeconds(2);
        cardList[i].GetComponent<CardScript>().Toggle();
        cardList[cardUpIndex].GetComponent<CardScript>().Toggle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
