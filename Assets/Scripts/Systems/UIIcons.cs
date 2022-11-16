using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIIcons : _System
{
    [SerializeField] private GameObject icon;
    public int count;

    List<GameObject> childs = new List<GameObject>();
    void Update()
    {
        for (int i=0;i<count;i++)
        {
            if (childs.Count <= i)
            {
                childs.Add(Instantiate(icon, transform));
            }
            childs[i].SetActive(true);
        }

        for (int i=Mathf.Max(count, 0);i<childs.Count;i++)
        {
            childs[i].SetActive(false);
        }
    }
}
