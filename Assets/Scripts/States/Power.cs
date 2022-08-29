using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
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
