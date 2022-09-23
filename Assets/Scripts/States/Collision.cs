using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    List<GameObject> collisionObjects = new List<GameObject>();

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collisionObjects.Add(collision.gameObject);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collisionObjects.Remove(collision.gameObject);
    }

    public List<GameObject> GetCollisionObjects()
    {
        return collisionObjects;
    }
}
