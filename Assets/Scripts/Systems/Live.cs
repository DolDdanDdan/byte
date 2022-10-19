using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Live : MonoBehaviour
{
    void Update()
    {
        Health _health = GetComponent<Health>();
        Timelimit _timelimit = GetComponent<Timelimit>();
        OnceDamaged _once_damaged = GetComponent<OnceDamaged>();

        if (!_health)
        {
            return;
        }

        if (_timelimit)
        {
            _health.Damaged(_health.maxHealth * Time.deltaTime / _timelimit.time);
        }

        if (_once_damaged && _once_damaged.isFinish)
        {
            _health.Damaged(_health.maxHealth);
        }

        if (_health.isDead)
        {
            // todo : death effect
            gameObject.SetActive(false);
        }
    }
}
