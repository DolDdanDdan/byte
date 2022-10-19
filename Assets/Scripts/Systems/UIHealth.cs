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
            // todo : if healthPercent is 100%, then hide health bar
            /*
            if (_health.healthPercent >= 1f)
            {
                gameObject.SetActive(false);
                return;
            }
            gameObject.SetActive(true);
            */
            healthBar.SetValue(_health.healthPercent);
        }
    }
}
