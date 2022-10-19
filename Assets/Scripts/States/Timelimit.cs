using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timelimit : MonoBehaviour
{
    [SerializeField] private float _time;

    public float time
    {
        get
        {
            return _time;
        }
    }
}
