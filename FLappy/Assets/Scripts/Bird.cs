using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float upForce = 200f;

    // colision = dead
    private bool isDead = false;

    // j'ai Rigidbody 2D
    private Rigidbody2D rb2d;

    // j'ai un animator
    private Animator anim; 


   // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animator>();
    }

    //si je suis en vie je peux flip
    void Update()
    {
        if(isDead == false)
        {
            //applique une force quand j'appuie sur Space
            if (Input.GetKeyDown("space"))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("Flap");
            }
        }

    }

    //j'ai une collison 2D
     void OnCollisionEnter2D ()
    {
        rb2d.velocity = Vector2.zero;
        isDead = true;
        anim.SetTrigger("Die");
        GameControl.instance.BirdDied ();
    }
}
