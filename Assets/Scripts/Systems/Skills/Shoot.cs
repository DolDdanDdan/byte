using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : _SkillSystem
{
    Bullet _bullet;
    Target _target;

    void Start()
    {
        _bullet = GetComponent<Bullet>();
        _target = GetComponent<Target>();

        _skill_state = _bullet;
    }

    public override void useSkill()
    {
        if (!isSkillEnable()) return;
        useCost();


        Quaternion rotation = transform.rotation;

        if (_target && _target.target)
        {
            Vector2 look_vector = _target.moveVector;
            Vector3 target_vector = Quaternion.Euler(0, 0, 90) * look_vector;
            rotation = Quaternion.LookRotation(Vector3.forward, target_vector);
        }
        else
        {
            if (_bullet.need_target)
            {
                return;
            }
        }

        Instantiate(_bullet.bullet, transform.position, rotation);
    }
}
