using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnceDamaged : MonoBehaviour
{
    [SerializeField] private bool isDead = false;

    private bool _isFinish = false;

    public bool isFinish
    {
        get
        {
            return _isFinish;
        }
    }

    public void damaged_finish()
    {
        _isFinish = true;
    }
}
