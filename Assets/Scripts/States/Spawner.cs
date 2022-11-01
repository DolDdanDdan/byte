using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _spawnObjects;
    [SerializeField] private float _spawnTime;
    [SerializeField] private float _lifeTime;
    [SerializeField] private float _needEnergy;
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
            return _spawnTime;
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
            return _needEnergy;
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
