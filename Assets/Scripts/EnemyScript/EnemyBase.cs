using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{

    public float enemySpeed;
    public float enemyCurrentHealth;
    public float enemyDamage;
    public float enemySize;
    public Transform enemyTarget;
    public float rotationSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //1.
      //transform.LookAt(enemyTarget);
       
        Vector3 direction = enemyTarget.position - transform.position;

        Quaternion targetRotation = Quaternion.LookRotation(direction);

        transform.rotation = Quaternion.RotateTowards(transform.rotation,targetRotation, rotationSpeed * Time.deltaTime);
        transform.position = transform.position + (transform.forward * enemySpeed * Time.deltaTime);
    }
}
