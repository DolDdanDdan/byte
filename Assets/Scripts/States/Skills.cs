using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills : MonoBehaviour
{
    [SerializeField] List<Skill> skills;
    [SerializeField] Playable _playable;
    Skill selectedSkill;

    void Awake()
    {
        foreach (Skill skill in skills)
        {
            // todo : create skills object in child
            skill.getSkillObject();
        }
    }

    void Update()
    {
        if (_playable)
        {

        }
    }

    /*
    public void selectSkill(Skill s)
    {
        selectedSkill = s;
    }
    */
}
