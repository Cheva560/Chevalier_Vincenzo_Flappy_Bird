using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour

{
    //j'ai un rigibody
    private Rigidbody2D rb2d;
   

    
    void Start()
    {
        //j'ai un rigibody
        rb2d = GetComponent<Rigidbody2D>();

        //j'ai une velocity 
        rb2d.velocity = new Vector2(GameControl.instance.scrollsSpeed, 0);

    }

    
    void Update()
    {
        //si je suis game over alors je m'arrete 
       if (GameControl.instance.gameOver == true)
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}
