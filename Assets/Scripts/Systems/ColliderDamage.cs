using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDamage : MonoBehaviour
{
    Collision _collision;

    private void Start()
    {
        _collision = GetComponent<Collision>();
    }

    void Update()
    {
        Power _power = GetComponent<Power>();

        if (_collision && _power)
        {
            foreach (GameObject collisionObject in _collision.GetCollisionObjects())
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
