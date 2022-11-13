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

        Target _target = GetComponent<Target>();
        Rush _rush = GetComponent<Rush>();

        Speed _speed = GetComponent<Speed>();
        Eye _eye = GetComponent<Eye>();

        Vector2 moveVector = Vector2.zero;
        float angle = transform.eulerAngles.z * Mathf.PI / 180;

        if (_playable)
        {
            moveVector += _playable.moveVector;
        }

        if (_rush)
        {
            if (_target)
            {
                if (_target.moveVector.magnitude > 1)
                {
                    moveVector += _target.moveVector.normalized;
                }
                else
                {
                    moveVector += _target.moveVector;
                }
            }
            else
            {
                moveVector += new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
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
            Debug.Log("not having rigidbody2d");
            // transform.position += (Vector3) moveVector;
        }
    }
}
