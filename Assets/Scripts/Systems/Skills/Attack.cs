using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : _SkillSystem
{
    GameObject attack_object;

    Animator attack_anime;

    Vector2 lookVector;

    void Start()
    {
        attack_object = GetComponent<Melee>().attack_object;

        attack_anime = attack_object.GetComponent<Animator>();

        _skill_state = GetComponent<Melee>();
    }

    void Update()
    {
        UpdateTime();

        Playable playable = GetComponent<Playable>();

        if (playable)
        {
            if (attack_anime)
            {
                lookVector = playable.mousePosition.normalized;
            }

            detectKey();
        }
    }

    public override void useSkill()
    {
        if (!isSkillEnable()) return;
        useCost();

        float atan2 = Mathf.Atan2(lookVector.y, lookVector.x);

        attack_object.transform.rotation = Quaternion.Euler(0.0f, 0.0f, atan2 * Mathf.Rad2Deg - 90);
        attack_object.transform.localPosition = lookVector * 0.1f;

        attack_anime.ResetTrigger("attacked");
        attack_anime.SetTrigger("attacked");
    }
}
