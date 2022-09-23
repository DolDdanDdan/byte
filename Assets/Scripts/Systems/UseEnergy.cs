using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseEnergy : MonoBehaviour
{
    Energy _energy;
    
    void Start()
    {
        _energy = GetComponent<Energy>();

        if (_energy)
        {
            _energy.energy = 0;
        }
    }

    void Update()
    {
        if (_energy)
        {
            _energy.addEnergy(Time.deltaTime);
        }
    }
}
