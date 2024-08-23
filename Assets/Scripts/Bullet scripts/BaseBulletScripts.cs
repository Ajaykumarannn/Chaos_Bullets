using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBulletScripts : MonoBehaviour
{
    public float bulletSpeed = 50f;

    private void OnCollisionEnter(Collision collision)
    {
        //Enter Code to do Damage
        Destroy(gameObject);
    }

    void Update()
    {
        transform.Translate(transform.position * bulletSpeed * Time.deltaTime);        
    }
}
