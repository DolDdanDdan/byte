using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dashed : _SkillSystem
{
    Dash _dash;

    void Start()
    {
        _dash = GetComponent<Dash>();
    }

    private void Update()
    {
    }

    public override void useSkill()
    {

    }

}
