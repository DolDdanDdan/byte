using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : _State
{
    [SerializeField] private float _damage = 1.0f;

    public float damage
    {
        get
        {
            return _damage;
        }
    }
}
