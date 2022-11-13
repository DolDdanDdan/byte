using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class _SkillState : _State
{
    [SerializeField] public float _need_time;
    [SerializeField] public float _need_energy;

    [System.NonSerialized] public float _time;

    public KeyCode keyCode;
}
