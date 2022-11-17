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
        _skill_state = _spawner;
    }

    public override void useSkill()
    {
        if (!isSkillEnable()) return;
        useCost();

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
