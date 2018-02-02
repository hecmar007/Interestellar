using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointPull : MonoBehaviour {

    #region Variables

    public int spawnPointsPoolSize = 5;
    public GameObject spawnPrefab;
    public float spawnRate = 4f;

    private GameObject[] spawnPoints;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;

    [SerializeField] private float spawnXPosition = 0f;
    [SerializeField] private float spawnYPosition = 6f;
    private int currentSpawnPoint = 0;
	#endregion

	void Start ()
	{
        spawnPoints = new GameObject[spawnPointsPoolSize];
        for (int i = 0; i < spawnPointsPoolSize; i++)
        {
            spawnPoints[i] = (GameObject)Instantiate(spawnPrefab, objectPoolPosition, Quaternion.identity);
        }
	}

	void Update ()
	{
        timeSinceLastSpawned += Time.deltaTime;

        if(timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            spawnPoints[currentSpawnPoint].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentSpawnPoint++;
            if(currentSpawnPoint >= spawnPointsPoolSize)
            {
                currentSpawnPoint = 0;
            }
        }
	}
}
