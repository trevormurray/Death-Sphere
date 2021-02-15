using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public int initialSpawnCounter = 1000;
    private float spawnCounterLimit;
    public static float spawnCounter;
    public static float spawnCounter2;
    public static float spawnCounter3;
    public static int difficultyLevel;
    private float difficultyModifier;
    public static int displayMax; // Remove after testing
    // Start is called before the first frame update
    void Start()
    {
        spawnCounterLimit = initialSpawnCounter;
        spawnCounter = spawnCounterLimit;
    }

    // Update is called once per frame
    void Update()
    {
        // Update difficulty level
        difficultyLevel = Mathf.Max(1, (PlayerController.kills / 10) + 1);

        // Update difficulty modifier
        difficultyModifier = difficultyLevel * 0.25f;

        // Update spawn counter limit
        spawnCounterLimit = initialSpawnCounter - difficultyModifier;
        if (spawnCounterLimit < 0.5)
        {
            spawnCounterLimit = 0.5f;
        }

        // Countdown spawn counter
        spawnCounter -= Time.deltaTime;

        // Spawn random enemy when counter is up
        if (spawnCounter <= 0)
        {
            Debug.Log("Spawning Random Enemy");
            SpawnRandomEnemy();
            if (difficultyLevel > 3)
            {
                spawnCounter2 = 1;                      // Enable second spawn counter
            }
            spawnCounter = spawnCounterLimit;
        }

        if (spawnCounter2 > 0)
        {
            spawnCounter2 -= Time.deltaTime;
            if (spawnCounter2 <= 0)
            {
                SpawnRandomEnemy();
                if (difficultyLevel > 9)
                {
                    spawnCounter3 = 1;                  // Enable third spawn counter
                }
                spawnCounter2 = 0;
            }

        }

        if (spawnCounter3 > 0)
        {
            spawnCounter3 -= Time.deltaTime;
            if (spawnCounter3 <= 0)
            {
                SpawnRandomEnemy();
                spawnCounter3 = 0;
            }

        }


    }

    void SpawnRandomEnemy()
    {
        float halfDiff = difficultyLevel / 2;
        int currentMax = (int) Mathf.Round(halfDiff) + 1;
        displayMax = currentMax;
        int enemyIndex = Random.Range(0, Mathf.Min(currentMax, enemyPrefabs.Length));
        Vector3 spawnPosition = new Vector3(Random.Range(-17, 17), 3, 28);
        Instantiate(enemyPrefabs[enemyIndex], spawnPosition, enemyPrefabs[enemyIndex].transform.rotation);
    }


}
