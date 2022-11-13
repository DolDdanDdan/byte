using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSkills : _System
{
    [SerializeField] private List<_SkillSystem> _skill_systems;

    private void Update()
    {
        foreach (_SkillSystem _skill_system in _skill_systems)
        {
            _skill_system.useSkill();
        }
    }
}
