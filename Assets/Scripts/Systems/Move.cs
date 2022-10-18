using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private Radar _radar;
    Rigidbody2D _rigid = null;

    void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Playable _playable = GetComponent<Playable>();

        Following _following = GetComponent<Following>();
        Rush _rush = GetComponent<Rush>();

        Speed _speed = GetComponent<Speed>();
        Eye _eye = GetComponent<Eye>();

        Vector2 moveVector = Vector2.zero;

        if (_playable)
        {
            moveVector += _playable.moveVector;
        } 

        if (_following)
        {
            moveVector += _following.moveVector;
        }

        if (_rush)
        {
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

        if (_rigid)
        {
            _rigid.velocity = moveVector;
        }
        else
        {
            transform.position += (Vector3)moveVector;
        }
    }
}
