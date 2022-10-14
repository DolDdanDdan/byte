using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureSet : MonoBehaviour
{
    [SerializeField] private List<Color> colors;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        Random.InitState((int)System.DateTime.Now.Ticks);

        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = colors[Random.Range(0, colors.Count)];
    }

}

