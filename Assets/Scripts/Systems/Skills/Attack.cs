using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private GameObject attack_object;

    SpriteRenderer attack_sprite_renderer;
    Collider2D attack_collider2d;
    // ColliderDamage attack_collider_damage_system;

    Animator attack_anime;

    void Start()
    {
        attack_collider2d = attack_object.GetComponent<Collider2D>();
        // attack_collider_damage_system =
        // attack_collider_damage_system.enabled = false;

        attack_sprite_renderer = attack_object.GetComponent<SpriteRenderer>();
        attack_anime = attack_object.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Playable playable = GetComponent<Playable>();


        if (playable && playable.mouseClick)
        {
            Start_Attack(playable.mousePosition);
        }

        /*
        if (playable && playable.spaceKey)
        {
            Start_Attack(playable.lastMoveVector);
        }
        */

        attack_collider2d.enabled = attack_sprite_renderer.enabled;
        // attack_object.SetActive(attack_sprite_renderer.enabled);
    }

    void Start_Attack(Vector2 attackVector)
    {
        if (attack_anime)
        {
            Vector2 lookVector = attackVector.normalized;

            float atan2 = Mathf.Atan2(lookVector.y, lookVector.x);

            // attack_object.SetActive(true);
            attack_object.transform.rotation = Quaternion.Euler(0.0f, 0.0f, atan2 * Mathf.Rad2Deg - 90);
            attack_object.transform.localPosition = lookVector * 0.75f;

            attack_anime.ResetTrigger("attacked");
            attack_anime.SetTrigger("attacked");
        }
    }
}