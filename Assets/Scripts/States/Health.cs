using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 10.0f;
    private bool _isDead = false;

    public bool isDead
    {
        get
        {
            return _isDead;
        }
    }

    private float health;

    public float maxHealth
    {
        get
        {
            return _maxHealth;
        }
    }
    
    public float healthPercent
    {
        get
        {
            return health / maxHealth;
        }
    }

    void Awake()
    {
        health = maxHealth;
        _isDead = false;
    }

    public void Damaged(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            _isDead = true;
        }
    }
}
