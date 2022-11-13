using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : _SkillSystem
{
    Bullet _bullet;
    Energy _energy;
    Target _target;

    void Start()
    {
        _bullet = GetComponent<Bullet>();
        _energy = GetComponent<Energy>();
        _target = GetComponent<Target>();
    }

    void Update()
    {
        UpdateTime(_bullet);
        detectKey(_bullet);
    }

    public override void useSkill()
    {
        if (_bullet)
        {
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

            if (_energy 
             && _energy.useEnergy(_bullet.need_energy))
            {
                Instantiate(_bullet.bullet, transform.position, rotation);
            }
        }
    }
}
