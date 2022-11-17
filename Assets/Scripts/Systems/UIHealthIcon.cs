using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthIcon : _System
{
    [SerializeField] private GameObject verticalObject;
    [SerializeField] private GameObject horizontalObject;

    [SerializeField] private Health _health;

    List<GameObject> healthLines = new List<GameObject>();

    void Update()
    {
        int health = 0;

        if (_health)
        {
            health = (int)_health.health;
        }

        if (!horizontalObject || !verticalObject)
        {
            return;
        }


        for (int index = 0; health > 0 || index < healthLines.Count; index++)
        {
            if (healthLines.Count <= index)
            {
                healthLines.Insert(0, Instantiate(horizontalObject, verticalObject.transform));
            }

            healthLines[index].GetComponent<UIIcons>().count = Mathf.Min(health, 10);

            health -= 10;
        }
    }
}
