using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D _rigid = null;

    void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Playable _playable = GetComponent<Playable>();
        Speed _speed = GetComponent<Speed>();

        if (_rigid != null && _playable != null)
        {
            Vector2 moveVector = _playable.moveVector;

            if (_speed != null)
            {
                moveVector *= _speed.speed;
            }
            _rigid.velocity = moveVector;
        }
    }
}
