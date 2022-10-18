using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Following : MonoBehaviour
{
    [SerializeField] private Transform _transform;

    public Vector2 moveVector
    {
        get
        {
            Vector2 moveVector = _transform.position - transform.position;
            return moveVector;
        }
    }
}
