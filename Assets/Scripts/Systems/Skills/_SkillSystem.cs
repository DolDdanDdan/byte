using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class _SkillSystem : _System
{
    protected _SkillState _skill_state;

    abstract public void useSkill();

    private void Update()
    {
        UpdateTime();
        detectKey();
    }

    protected void UpdateTime()
    {
        if (!_skill_state) return;

        _skill_state._time -= Time.deltaTime;

        if (_skill_state._time < 0)
        {
            _skill_state._time = 0;
        }

        return;
    }

    protected void detectKey()
    {
        Playable playable = GetComponent<Playable>();

        if (!playable) return;
        if (!_skill_state) return;

        if (Input.GetKeyDown(_skill_state.keyCode)
         && isSkillEnable())
        {
            useSkill();
        }
    }

    protected bool isSkillEnable()
    {
        if (!_skill_state)
        {
            return false;
        }

        Energy _energy = GetComponent<Energy>();

        float energy = 0f;

        if (_energy)
        {
            energy = _energy.energy;
        }

        return _skill_state._time == 0 && _skill_state._need_energy <= energy;
    }

    protected void useCost()
    {
        _skill_state._time += _skill_state._need_time;

        Energy _energy = GetComponent<Energy>();

        if (_energy)
        {
            _energy.useEnergy(_skill_state._need_energy);
        }
    }
}
