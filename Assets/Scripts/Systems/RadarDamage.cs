using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarDamage : MonoBehaviour
{
    [SerializeField] private Radar _radar;

    void Update()
    {
        Power _power = GetComponent<Power>();
        Team _team = GetComponent<Team>();
        OnceDamaged _once_damaged = GetComponent<OnceDamaged>();

        if (_once_damaged && _once_damaged.isFinish)
        {
            return;
        }

        if (_radar)
        {
            List<GameObject> radarObjects = _radar.GetRadarObjects();

            if (_team)
            {
                radarObjects = _team.GetOtherTeamObjects(radarObjects);
            }

            foreach (GameObject radarObject in radarObjects)
            {
                Health _radar_health = radarObject.GetComponent<Health>();

                if (_radar_health)
                {
                    if (_power)
                    {
                        _radar_health.Damaged(_power.damage);
                    }
                    else
                    {
                        _radar_health.Damaged(1);
                    }

                    if (_once_damaged)
                    {
                        _once_damaged.damaged_finish();
                    }
                }
            }
        }
    }
}
