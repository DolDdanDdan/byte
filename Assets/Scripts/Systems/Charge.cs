using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charge : MonoBehaviour
{
    [SerializeField] private float power = 1f;
    [SerializeField] private Energy _energy;
    
    void Update()
    {
        if (_energy)
        {
            _energy.addEnergy(Time.deltaTime * power);
        }
    }
}
