using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteoriteSpawn : MonoBehaviour {

    #region Variables

    public GameObject[] meteorites;
    public GameObject[] spawnPoints;

    private int meteoriteToSpawn;
    private int whereToSpawn;
    private int howManyToSpawn;

    private bool isTaken1 = false;
    private bool isTaken2 = false;
    private bool isTaken3 = false;
    private bool isTaken4 = false;
    private bool isTaken5 = false;

    public GameObject trigger;

    CircleCollider2D circle;

    private int i = 0;
    #endregion

	void Start ()
	{
        howManyToSpawn = Random.Range(2, 4);

        Instantiate(trigger, spawnPoints[2].transform.position, spawnPoints[2].transform.rotation); //Això activarà el trigger

        while (i <= howManyToSpawn)
        {
            meteoriteToSpawn = Random.Range(0, meteorites.Length);
            whereToSpawn = Random.Range(0, spawnPoints.Length);
            circle = meteorites[meteoriteToSpawn].GetComponent<CircleCollider2D>();

            if (!isTaken1 && whereToSpawn == 1)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (!isTaken2 && whereToSpawn == 2)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (!isTaken3 && whereToSpawn == 3)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (!isTaken4 && whereToSpawn == 4)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (!isTaken5 && whereToSpawn == 5)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (whereToSpawn == 1)
            {
                isTaken1 = true;
            }
            if (whereToSpawn == 2)
            {
                isTaken2 = true;
            }
            if (whereToSpawn == 3)
            {
                isTaken3 = true;
            }
            if (whereToSpawn == 4)
            {
                isTaken4 = true;
            }
            if (whereToSpawn == 5)
            {
                isTaken5 = true;
            }

        }
    }

	void Update ()
	{

       
    }
    
    public void respawn()
    {
            isTaken1 = false;
            isTaken2 = false;
            isTaken3 = false;
            isTaken4 = false;
            isTaken5 = false;
            i = 0;
        //Resetejar totes les variables
        howManyToSpawn = Random.Range(2, 4);

        Instantiate(trigger, spawnPoints[2].transform.position, spawnPoints[2].transform.rotation);

        while (i <= howManyToSpawn)
        {
            meteoriteToSpawn = Random.Range(0, meteorites.Length);
            whereToSpawn = Random.Range(0, spawnPoints.Length);
            circle = meteorites[meteoriteToSpawn].GetComponent<CircleCollider2D>();
            if (!isTaken1 && whereToSpawn == 1)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (!isTaken2 && whereToSpawn == 2)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (!isTaken3 && whereToSpawn == 3)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (!isTaken4 && whereToSpawn == 4)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (!isTaken5 && whereToSpawn == 5)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (whereToSpawn == 1)
            {
                isTaken1 = true;
            }
            if (whereToSpawn == 2)
            {
                isTaken2 = true;
            }
            if (whereToSpawn == 3)
            {
                isTaken3 = true;
            }
            if (whereToSpawn == 4)
            {
                isTaken4 = true;
            }
            if (whereToSpawn == 5)
            {
                isTaken5 = true;
            }
        }
    }
}
