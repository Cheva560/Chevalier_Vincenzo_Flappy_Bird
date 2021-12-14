using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour

{   //plusiers parametre pour les collonne 

    //Taille
    public int columnPoolSize = 5;
    //prefab
    public GameObject columPrefabs;

    //vitesse de spawn
    public float spawnRate = 4f;

    //vitesse Min 
    public float columnMin = -1f;

    //vitesse Max 
    public float columnMax = 3.5f;

    //prnd le prefab 
    private GameObject[] columns;

    //emplacement de la pool position qui permet le spawn des collonne 
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);

    //spawn
    public float timeSinceLastSpawned;

    //spwn position
    private float spawnXPosition = 10f;

    //nombre de collonne
    private int currentColumn = 0;

   
    void Start()
    {
        //Object
        columns = new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++)
        {
            columns [i] = (GameObject)Instantiate(columPrefabs, objectPoolPosition, Quaternion.identity);

        }
    }

   
    void Update()
    {
        //Si gameOver alors les colonne arrete de span
       timeSinceLastSpawned += Time.deltaTime;

        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range(columnMin, columnMax);
            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentColumn++;
            if (currentColumn>=columnPoolSize)
            {
                currentColumn = 0;
            }
        }
    }
}
