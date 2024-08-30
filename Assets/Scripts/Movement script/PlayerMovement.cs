using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Vector2 movementValues = Vector2.zero;
    Vector2 lookingValues = Vector2.zero;
    public float FrameDistance = 100f;
    public float LookSpeed = 0.1f;
    public GameObject bulletprefab;

    HealthandDamage hdComponent;

    
    public void IAAccelerate(InputAction.CallbackContext context)
    {
        movementValues = context.ReadValue<Vector2>();
    }

    public void IALooking(InputAction.CallbackContext context)
    {
        lookingValues =context.ReadValue<Vector2>();

        transform.Rotate(transform.up, lookingValues.x * Time.deltaTime* LookSpeed);

    }

    public void IAShoot(InputAction.CallbackContext context)
    {
        Shoot();
    }

    private void Awake()
    {
        hdComponent = gameObject.GetComponent<HealthandDamage>();
    }

    void Update()
    {
        transform.Translate(movementValues.x * FrameDistance *Time.deltaTime, 0, movementValues.y * FrameDistance*Time.deltaTime);
    }

    public void Shoot()
    {
        GameObject spawnedBullet;
        Vector3 direction = (transform.forward * 100f) - transform.position;
        spawnedBullet = Instantiate(bulletprefab, transform.position + transform.forward, Quaternion.identity);
        spawnedBullet.GetComponent<BaseBulletScripts>().SetBulletDirection(direction);

        spawnedBullet.GetComponent<BaseBulletScripts>().bulletDamage = hdComponent.damage;
    }
    
}
