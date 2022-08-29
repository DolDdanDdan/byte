using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth = 10.0f;
    
    public float health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    void Awake()
    {
        health = maxHealth;
    }
}
