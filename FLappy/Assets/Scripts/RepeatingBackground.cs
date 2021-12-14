using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    //j'ai une collsion 
    private BoxCollider2D groundCollider;

    //taille 
    private float groundHorizontaLenghth;



   
    void Start()
    {
        //je recupére la collison 
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontaLenghth = groundCollider.size.x;

    }

    // Update is called once per frame
    void Update()
    {
        //position de base 
        if (transform.position.x < -groundHorizontaLenghth)
        {
            RepositionBackground();
        }
    }
     private void RepositionBackground()

    {
        //reposition quand j'attaint un certain point de la map alors je me Tp ce qui permet une illusion infini
        Vector2 groundOffset = new Vector2 (groundHorizontaLenghth * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
