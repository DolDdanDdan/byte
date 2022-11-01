using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : ScriptableObject
{
    float time;

    GameObject skillObject;

    public GameObject getSkillObject()
    {
        return skillObject;
    }
}
