using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    public GameObject bullet
    {
        get
        {
            return _bullet;
        }
    }
}
