using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth = 10.0f;
    private bool isDead = false;

    private float _health;
    
    public float health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
        }
    }

    void Awake()
    {
        health = maxHealth;
        isDead = false;
    }

    public void Damaged(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            isDead = true;
        }
    }
}
