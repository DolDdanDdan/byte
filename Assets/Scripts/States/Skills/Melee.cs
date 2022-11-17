using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : _SkillState
{
    [SerializeField] private GameObject melee_object;

    public GameObject attack_object
    {
        get
        {
            return melee_object;
        }
    }
}
