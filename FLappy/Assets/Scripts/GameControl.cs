using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;

    public GameObject gameOverText;

    public Text scoreText;

    //detect si game over 
    public bool gameOver = false;

    //détermine la vitesse du scrolling 
    public float scrollsSpeed = -1.5f;

    //définie le score de base 
    private int score = 0;

   //permet de relancer le jeu 
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

    }

    //Game Over et relnce
    void Update()
    {
        if (gameOver == true && Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    //Score
    public void BirdScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "Score " + score.ToString();
    }

    //Dead 
    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
