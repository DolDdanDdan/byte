using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : _State
{
    public enum TeamType
    {
        None,
        Player,
        Enemy
    }

    [SerializeField] private TeamType _team = TeamType.None;

    public TeamType team
    {
        get
        {
            return _team;
        }
    }

    public List<GameObject> GetOtherTeamObjects(List<GameObject> gameObjects)
    {
        if (team == TeamType.None)
        {
            return gameObjects;
        }

        List<GameObject> otherTeamObjects = new List<GameObject>();

        foreach (GameObject gameObject in gameObjects)
        {
            Team target_team = gameObject.GetComponent<Team>();

            if (target_team && target_team.team != TeamType.None)
            {
                if (target_team.team == team)
                    continue;
            }

            otherTeamObjects.Add(gameObject);
        }

        return otherTeamObjects;
    }
}
