using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : _State
{
    private List<GameObject> radarGameObjects = new List<GameObject>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        radarGameObjects.Add(collision.gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        radarGameObjects.Remove(collision.gameObject);
    }

    public List<GameObject> GetRadarObjects()
    {
        return radarGameObjects;
    }
}
