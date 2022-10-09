using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private GameObject eye;
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

        if (eye)
        {
            eye.transform.localPosition = Vector2.Lerp(
                eye.transform.localPosition,
                moveVector * 0.1f,
                0.5f
            );
        }

        if (_speed)
        {
            moveVector *= _speed.speed;
        }
        _rigid.velocity = moveVector;
    }
}
