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
        Rush _rush = GetComponent<Rush>();
        Speed _speed = GetComponent<Speed>();

        if (!_rigid)
        {
            return;
        }

        Vector2 moveVector = Vector2.zero;

        if (_playable)
        {
            moveVector += _playable.moveVector;
        } 
        if (_rush)
        {
            Radar _radar = GetComponent<Radar>();

            _rush.SetTarget(_radar.GetRadarObjects());

            moveVector += _rush.moveVector;
        }

        if (_speed)
        {
            moveVector *= _speed.speed;
        }
        _rigid.velocity = moveVector;
    }
}
