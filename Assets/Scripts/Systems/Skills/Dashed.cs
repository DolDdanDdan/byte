using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dashed : _SkillSystem
{
    Dash _dash;

    void Start()
    {
        _dash = GetComponent<Dash>();
        _skill_state = _dash;
    }

    public override void useSkill()
    {
        if (!isSkillEnable()) return;
        useCost();

        Playable _playable = GetComponent<Playable>();

        Target _target = GetComponent<Target>();
        Rush _rush = GetComponent<Rush>();

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

        _dash._dash_rotate += moveVector * _dash._speed;
    }
}
