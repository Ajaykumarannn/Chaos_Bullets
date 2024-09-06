using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthandDamage : MonoBehaviour
{
    public float MaxHealth = 100f;
    public float Health = 100f;
    public float damage = 10f;

    delegate void DamageTakenDelegate(float incomingDamage);

    DamageTakenDelegate delegate_DamageTaken;

    private void Start()
    {
        delegate_DamageTaken = AcceptDamage;
    }

    public void AcceptDamage(float incomingDamage)
    {
        Health = Health - incomingDamage;

        if (Health < 0)
        {
            Death();
        }
    }

    public void Death()
    {
        Destroy(gameObject);
    }

    public float GetHealthRatio()
    {
        return Health/MaxHealth;
    }

    
}