using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTargetNearest : MonoBehaviour
{
    [SerializeField] private Radar _radar;
    [SerializeField] private Target _target;

    void Update()
    {
        Team _team = GetComponent<Team>();

        if (_target)
        {
            if (_radar)
            {
                List<GameObject> targets = _radar.GetRadarObjects();

                if (_team)
                {
                    targets = _team.GetOtherTeamObjects(targets);
                }

                SetTarget(targets);
            }
        }
    }

    public void SetTarget(List<GameObject> gameObjects)
    {
        if (_target.target)
        {
            if (gameObjects.Contains(_target.target))
            {
                return;
            }
            else
            {
                _target.target = null;
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

        _target.target = nearestObject;
    }
}
