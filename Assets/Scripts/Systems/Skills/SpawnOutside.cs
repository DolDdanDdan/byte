using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOutside : _SkillSystem
{
    [SerializeField] private float range;
    Spawner _spawner;

    void Start()
    {
        _spawner = GetComponent<Spawner>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTime(_spawner);
        detectKey(_spawner);
    }

    public override void useSkill()
    {
        if (_spawner)
        {
            if (_spawner._time > 0) return;

            _spawner._time += _spawner._need_time;

            List<GameObject> spawnObjects = _spawner.spawnObjects;

            foreach (GameObject spawnObject in spawnObjects)
            {
                float rotation = Random.Range(-Mathf.PI, Mathf.PI);

                Vector2 spawnPoint = transform.position;
                spawnPoint += new Vector2(Mathf.Cos(rotation), Mathf.Sin(rotation)) * range;

                Instantiate(spawnObject, spawnPoint, Quaternion.identity);
            }
        }
    }
}
