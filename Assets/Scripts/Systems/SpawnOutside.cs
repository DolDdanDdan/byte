using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOutside : MonoBehaviour
{
    [SerializeField] private float range;
    float time;
    Spawner spawner;

    void Start()
    {
        spawner = GetComponent<Spawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawner)
        {
            time -= Time.deltaTime;
            if (time > 0) return;

            time += spawner.spawnTime;

            List<GameObject> spawnObjects = spawner.spawnObjects;

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
