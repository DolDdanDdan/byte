using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDamage : MonoBehaviour
{
    [SerializeField] private Collision _collision;

    void Update()
    {
        Power _power = GetComponent<Power>();
        Team _team = GetComponent<Team>();
        OnceDamaged _once_damaged = GetComponent<OnceDamaged>();

        if (_once_damaged && _once_damaged.isFinish)
        {
            return;
        }

        if (_collision)
        {
            List<GameObject> collisionObjects = _collision.GetCollisionObjects();

            if (_team)
            {
                collisionObjects = _team.GetOtherTeamObjects(collisionObjects);
            }

            foreach (GameObject collisionObject in collisionObjects)
            {
                Health _collision_health = collisionObject.GetComponent<Health>();

                if (_collision_health)
                {
                    if (_power)
                    {
                        _collision_health.Damaged(_power.damage);
                    }
                    else
                    {
                        _collision_health.Damaged(1);
                    }

                    if (_once_damaged)
                    {
                        _once_damaged.damaged_finish();
                    }
                }
            }
        }
    }
}
