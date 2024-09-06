using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUi : MonoBehaviour
{
    public Image healthBar;

    private void Start()
    {
        healthBar.fillAmount = GetComponent<HealthandDamage>().GetHealthRatio();
    }

    public void UpdateHealthBar(float newHealthRatio)
    {
        
    }
}
