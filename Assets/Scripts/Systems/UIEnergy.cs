using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEnergy : _System
{
    [SerializeField] private Text _text;
    [SerializeField] private Energy _energy;

    void Update()
    {
        if (_text && _energy)
        {
            _text.text = Mathf.FloorToInt(_energy.energy).ToString();
        } 
    }
}
