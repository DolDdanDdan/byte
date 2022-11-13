using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : _SkillState
{
    [SerializeField] private List<GameObject> _spawnObjects;
    [SerializeField] private float _lifeTime;
    [SerializeField] private bool _needTarget;

    public List<GameObject> spawnObjects
    {
        get
        {
            return _spawnObjects;
        }
    }

    public float spawnTime
    {
        get
        {
            return _need_time;
        }
    }
    public float lifeTime
    {
        get
        {
            return _lifeTime;
        }
    }

    public float needEnergy
    {
        get
        {
            return _need_energy;
        }
    }

    public bool needTarget
    {
        get
        {
            return _needTarget;
        }
    }
}
