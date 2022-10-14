using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    [SerializeField] private List<Color> _colors;
    public List<Color> colors
    {
        get
        {
            return _colors;
        }
    }
}
