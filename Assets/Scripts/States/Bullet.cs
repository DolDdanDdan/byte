using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _need_energy;
    [SerializeField] private bool _need_target;
    [SerializeField] private float _life_time;

    public GameObject bullet
    {
        get
        {
            return _bullet;
        }
    }

    public float need_energy
    {
        get
        {
            return _need_energy;
        }
    }

    public bool need_target
    {
        get
        {
            return _need_target;
        }
    }

    public float life_time
    {
        get
        {
            return _life_time;
        }
    }
}
