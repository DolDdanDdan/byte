using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : _State
{
    [SerializeField] private float _maxEnergy = 1f;

    private float _energy = 0.0f;

    public float energy
    {
        get
        {
            return _energy;
        }
    }

    public void addEnergy(float delta)
    {
        _energy += delta;
        if (_energy > _maxEnergy)
        {
            _energy = _maxEnergy;
        }
    }

    public bool useEnergy(float use_energy)
    {
        if (_energy >= use_energy)
        {
            _energy -= use_energy;
            return true;
        }
        return false;
    }
}
