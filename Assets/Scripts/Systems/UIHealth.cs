using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHealth : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private HealthBar healthBar;

    void Update()
    {
        if (_health && healthBar)
        {
            if (_health.healthPercent >= 1f)
            {
                healthBar.SetEnable(false);
                return;
            }
            healthBar.SetEnable(true);
            healthBar.SetValue(_health.healthPercent);
        }
    }
}
