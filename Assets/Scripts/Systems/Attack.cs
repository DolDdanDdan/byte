using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private GameObject attack_object;

    private SpriteRenderer attack_sprite_renderer;
    private ColliderDamage attack_collider_damage_system;

    Animator attack_anime;

    void Start()
    {
        attack_collider_damage_system = attack_object.AddComponent<ColliderDamage>();
        attack_collider_damage_system.enabled = false;

        attack_sprite_renderer = attack_object.GetComponent<SpriteRenderer>();
        attack_anime = attack_object.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Playable playable = GetComponent<Playable>();

        if (playable && playable.spaceKey)
        {
            // todo : attack motion and check collision
            if (attack_anime)
            {
                Vector2 lookVector = playable.lastMoveVector;

                float atan2 = Mathf.Atan2(lookVector.y, lookVector.x);

                attack_object.transform.rotation = Quaternion.Euler(0.0f, 0.0f, atan2 * Mathf.Rad2Deg - 90);
                attack_object.transform.localPosition = lookVector * 0.75f;

                attack_anime.ResetTrigger("attacked");
                attack_anime.SetTrigger("attacked");
            }
        }

        attack_collider_damage_system.enabled = attack_sprite_renderer.enabled;
    }
}
