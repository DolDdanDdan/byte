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

        if (_collision && _power)
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
                    _collision_health.Damaged(_power.damage);
                }
            }
        }
    }
}
