using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Transform Player;
    private GameObject spawnedEnemy;
    public GameObject enemyToSpawn;
    private Vector3 enemySpawnposition;
    public float spawnEnemyFrequency = 1f;
    public float spawnTimer = 0f;

    public float maxSpawnRadius;
    public float minSpawnRadius;
    private float actualSpawnRadius;
    private float actualSpawnAngle;

    /// <summary>
    /// The variable enemySpawnFrequency refers to how many times per second we are going to spawn an enemy
    /// </summary>
    
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        spawnTimer = spawnTimer + 0.02f;
        if (spawnTimer >= spawnEnemyFrequency)
        {
            spawnTimer = 0;
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        actualSpawnRadius = Random.Range(maxSpawnRadius, minSpawnRadius);
        actualSpawnAngle = Random.Range(0, 360);

        enemySpawnposition = new Vector3(actualSpawnRadius * Mathf.Cos(actualSpawnAngle), 0, actualSpawnRadius * Mathf.Sin(actualSpawnAngle)); 

        spawnedEnemy = Instantiate(enemyToSpawn, enemySpawnposition,Quaternion.identity);
        spawnedEnemy.GetComponent<EnemyBase>().targetPlayer = Player;
    }
    /// This Function spawns an enemy prefab at a rate of the given spawn Frequency.

}
