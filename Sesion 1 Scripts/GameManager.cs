using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject[] e;
    GameObject[] e2;

    // Start is called before the first frame update
    void Start()
    {
        e = GameObject.FindGameObjectsWithTag("fighter");

        List<string> listName = new List<string> { };
        listName.Add("Scorpion");
        listName.Add("Kano");
        listName.Add("Sonya");
        listName.Add("Johnny Cage");
        listName.Add("Sub-Zero");

        List<string> listCategory = new List<string> { };
        listCategory.Add("Ninja");
        listCategory.Add("Mercenario");
        listCategory.Add("Teniente");
        listCategory.Add("Actor");
        listCategory.Add("Ninja");

        e2 = InitFighters(e, listName, listCategory);
        e = e2;

        foreach (GameObject fighter in e)
        {
            Debug.Log("["+fighter.name+"]"+"El nombre: " + fighter.GetComponent<Fighter>().Name+"; la categoria: " +
                fighter.GetComponent<Fighter>().Category+"; y la vida: " + fighter.GetComponent<Fighter>().Health);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject[] InitFighters(GameObject[] e, List<string> listName, List<string> listCategory)
    {
        for(int i=0; i < 5; i++)
        {
            e[i].GetComponent<Fighter>().Name = listName[i];
            e[i].GetComponent<Fighter>().Category = listCategory[i];
            e[i].GetComponent<Fighter>().Health = 100;
        }

        return e;
    }
}
