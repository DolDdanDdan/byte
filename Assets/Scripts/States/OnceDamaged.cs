using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnceDamaged : _State
{
    [SerializeField] private bool _isDead = false;
    public bool isDead
    {
        get
        {
            return _isDead;
        }
    }

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
