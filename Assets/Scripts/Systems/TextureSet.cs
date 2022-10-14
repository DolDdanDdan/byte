using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureSet : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        RandomColor _random_color = GetComponent<RandomColor>();

        Random.InitState((int)System.DateTime.Now.Ticks);

        if (_random_color)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.color = _random_color.colors[Random.Range(0, _random_color.colors.Count)];
        }
    }

}

