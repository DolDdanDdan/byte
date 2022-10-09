using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Live : MonoBehaviour
{
    void Update()
    {
        Health _health = GetComponent<Health>();

        if (!_health)
        {
            return;
        }

        if (_health.health <= 0)
        {
            // todo : death effect
            gameObject.SetActive(false);
        }
    }
}
