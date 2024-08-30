using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBulletScripts : MonoBehaviour
{
    public float bulletSpeed = 50f;
    public Rigidbody bulletRigidBody;
    private Vector3 direction;
    public float bulletDamage = 10f;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collison detected");
        Destroy(gameObject);
    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        bulletRigidBody.AddForce(direction * 40f);

        RaycastHit rayHit;

        if (Physics.Raycast(transform.position, bulletRigidBody.velocity.normalized, out rayHit,bulletRigidBody.velocity.magnitude * 0.02f))
        {
            rayHit.transform.gameObject.GetComponent<HealthandDamage>().AcceptDamage(bulletDamage);
        }

        Debug.DrawLine(transform.position, transform.position + bulletRigidBody.velocity);

    }

    public void SetBulletDirection(Vector3 desiredDirection)
    {
        direction = desiredDirection;
    }
}
