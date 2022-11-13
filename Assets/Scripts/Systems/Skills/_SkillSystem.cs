using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class _SkillSystem : _System
{
    abstract public void useSkill();

    public void UpdateTime(_SkillState _skill_state)
    {
        if (!_skill_state) return;

        _skill_state._time -= Time.deltaTime;

        if (_skill_state._time < 0)
        {
            _skill_state._time = 0;
        }

        return;
    }

    public void detectKey(_SkillState _skill_state)
    {
        if (!_skill_state) return;

        if (Input.GetKeyDown(_skill_state.keyCode))
        {
            useSkill();
        }
    }
}
