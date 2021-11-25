using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public string nombre;
    // Start is called before the first frame update
    void Start()
    {
        List<int> lista1 = new List<int> { };

        lista1.Add(5);
        lista1.Add(4);
        lista1.Add(8);

        /*lista1.Remove(4);

        Debug.Log(lista1.Count);
        Debug.Log(lista1[1]);*/

        Suma(lista1[1]);

        foreach (int elemento in lista1)
        {
            Debug.Log(elemento);
        }

        List<int> lista2 = new List<int> { };
        lista1.Add(5);
        lista1.Add(4);
        lista1.Add(8);

        if(lista1 == lista2)
        {
            Debug.Log("Las listas son iguales"); // para que se de esta condicion, como se almacenan en espacios diferentes (pese a tener los mismos valores), son distintas salvo que se diga que --> lista2 = lista1
        }
        else
        {
            Debug.Log("Las listas son distintas"); //inicialmente las listas son distintas.
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int Suma(int e) //si pasas un valor no se modifica el valor a no ser que hagas un return, otro caso es que pases una lista que el puntero enfocaria a un espacio de memoria por lo que si que cambiaria el valor sin necesidad de un return.
                    //int,string, bool es valor (dato simple, necesita return para cambiar el valor);
                    //en cambio lista, objeto, clase es paso por referencia y no necesita return ya que apunta a un espacio de memoria.
    {
        e++;

        return e;
    }
}
