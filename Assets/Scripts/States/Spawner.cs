using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _spawnObjects;
    [SerializeField] private float _spawnTime;
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
}
