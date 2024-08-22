using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    private float distancetoPlayer;
    public float enemySpeed;
    public float enemyCurrentHealth;
    public float enemyDamage;
    public float enemySize;
    public Transform targetPlayer;
    public float rotationSpeed = 1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //1.
        //transform.LookAt(enemyTarget);

        distancetoPlayer = Vector3.Distance(transform.position, targetPlayer.position);

        transform.position = transform.position + (transform.forward * enemySpeed * Time.deltaTime);
        Vector3 direction = targetPlayer.position - transform.position;

        Quaternion targetRotation = Quaternion.LookRotation(direction);

        transform.rotation = Quaternion.RotateTowards(transform.rotation,targetRotation, rotationSpeed * Time.deltaTime);
        transform.position = transform.position + (transform.forward * enemySpeed * Time.deltaTime);
    }
}
