using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update

    
   public GameObject enemyToSpawn;
    public float spawnEnemyFrequency = 1f;
    public float spawnTimer = 0f;
    /// <summary>
    /// The variable enemySpawnFrequency refers to how many times per second we are going to spawn an enemy
    /// </summary>
    
    private float spawnFrequency;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
    }
    private void FixedUpdate()
    {
        spawnTimer = spawnTimer + 0.02f;
        if (spawnTimer >= enemySpawnFrequency) ;
    }

    void SpawnEnemy()
    {

    }
    /// This Function spawns an enemy prefab at a rate of the given spawn Frequency.

}
