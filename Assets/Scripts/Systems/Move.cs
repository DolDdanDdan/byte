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
        Eye _eye = GetComponent<Eye>();
        
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
            Team _team = GetComponent<Team>();

            if (_radar)
            {
                List<GameObject> targets = _radar.GetRadarObjects();

                if (_team)
                {
                    targets = _team.GetOtherTeamObjects(targets);
                }

                _rush.SetTarget(targets);

                moveVector += _rush.moveVector;
            }
        }

        if (_eye && _eye.eyeType == Eye.EyeType.Move)
        {
            _eye.Move(moveVector);
        }

        if (_speed)
        {
            moveVector *= _speed.speed;
        }

        _rigid.velocity = moveVector;
    }
}
