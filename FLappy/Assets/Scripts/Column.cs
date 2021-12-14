using UnityEngine;
using System.Collections;

public class Column : MonoBehaviour
{
    //j'ai une collison 
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Bird>() != null)
        {
            //permet de detcter la collison pour ajouter du score
            GameControl.instance.BirdScored();
        }
    }
}

