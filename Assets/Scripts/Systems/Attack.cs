using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private GameObject attack_object;

    Animator attack_anime;

    void Start()
    {
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
                attack_anime.ResetTrigger("attacked");
                attack_anime.SetTrigger("attacked");
            }
        }
    }
}
