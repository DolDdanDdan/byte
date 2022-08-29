using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Set move speed
public class Speed : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;

    public float speed
    {
        get
        {
            return _speed;
        }
    }
}
