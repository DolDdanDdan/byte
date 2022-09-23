using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rush : MonoBehaviour
{
    private GameObject target;

    public Vector2 moveVector
    {
        get
        {
            if (target)
            {
                Vector2 v = target.transform.position - transform.position;
                return v.normalized;
            }
            else
            {
                return Vector2.zero;
            }
        }
    }

    public void SetTarget(List<GameObject> gameObjects)
    {
        if (target)
        {
            if (gameObjects.Contains(target))
            {
                return;
            }
            else
            {
                target = null;
            }
        }

        GameObject nearestObject = null;

        foreach (GameObject obj in gameObjects)
        {
            if (nearestObject)
            {
                if (Vector2.Distance(transform.position, obj.transform.position) 
                    < Vector2.Distance(transform.position, nearestObject.transform.position))
                {
                    nearestObject = obj;
                }
            } 
            else
            {
                nearestObject = obj;
            }
        }

        target = nearestObject;
    }
}
