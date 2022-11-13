using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : _State
{
    [SerializeField] private GameObject _target;

    public GameObject target
    {
        get
        {
            return _target;
        }
        set
        {
            _target = value;
        }
    }

    public Vector2 moveVector
    {
        get
        {
            if (_target)
            {
                Vector2 moveVector = _target.transform.position - transform.position;
                return moveVector;
            }
            else
            {
                return Vector2.zero;
            }
        }
    }
}
