using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

    #region Variables

    public GameObject[] meteorites;
    public GameObject[] spawnPoints;
    [SerializeField] public GameObject portal;

    private int meteoriteToSpawn;
    private int whereToSpawn;
    private int howManyToSpawn;
    private int portalSpawn;

    private bool isTaken1 = false;
    private bool isTaken2 = false;
    private bool isTaken3 = false;
    private bool isTaken4 = false;
    private bool isTaken5 = false;

    public GameObject trigger;

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

            if (!isTaken1 && whereToSpawn == 0)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (!isTaken2 && whereToSpawn == 1)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (!isTaken3 && whereToSpawn == 2)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (!isTaken4 && whereToSpawn == 3)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (!isTaken5 && whereToSpawn == 4)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (whereToSpawn == 0)
            {
                isTaken1 = true;
            }
            if (whereToSpawn == 1)
            {
                isTaken2 = true;
            }
            if (whereToSpawn == 2)
            {
                isTaken3 = true;
            }
            if (whereToSpawn == 3)
            {
                isTaken4 = true;
            }
            if (whereToSpawn == 4)
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
        portalSpawn = Random.Range(0, 1);

        Instantiate(trigger, spawnPoints[2].transform.position, spawnPoints[2].transform.rotation);

        #region whiletopellarg

        while (i <= howManyToSpawn)
        {

            meteoriteToSpawn = Random.Range(0, meteorites.Length);
            whereToSpawn = Random.Range(0, spawnPoints.Length);
            if (!isTaken1 && whereToSpawn == 0)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (!isTaken2 && whereToSpawn == 1)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (!isTaken3 && whereToSpawn == 2)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (!isTaken4 && whereToSpawn == 3)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (!isTaken5 && whereToSpawn == 4)
            {
                Instantiate(meteorites[meteoriteToSpawn], spawnPoints[whereToSpawn].transform.position, spawnPoints[whereToSpawn].transform.rotation);
                i++;
            }
            if (whereToSpawn == 0)
            {
                isTaken1 = true;
            }
            if (whereToSpawn == 1)
            {
                isTaken2 = true;
            }
            if (whereToSpawn == 2)
            {
                isTaken3 = true;
            }
            if (whereToSpawn == 3)
            {
                isTaken4 = true;
            }
            if (whereToSpawn == 4)
            {
                isTaken5 = true;
            }
        }
        #endregion

        if(portalSpawn == 0 && !isTaken1)
        {
            Instantiate(portal, spawnPoints[0].transform.position, spawnPoints[0].transform.rotation);
        }
         else if (portalSpawn == 0 && !isTaken2)
        {
            Instantiate(portal, spawnPoints[1].transform.position, spawnPoints[1].transform.rotation);
        }
        else if (portalSpawn == 0 && !isTaken3)
        {
            Instantiate(portal, spawnPoints[2].transform.position, spawnPoints[2].transform.rotation);
        }
        else if (portalSpawn == 0 && !isTaken4)
        {
            Instantiate(portal, spawnPoints[3].transform.position, spawnPoints[3].transform.rotation);
        }
        else if (portalSpawn == 0 && !isTaken5)
        {
            Instantiate(portal, spawnPoints[4].transform.position, spawnPoints[4].transform.rotation);
        }
    }
}
