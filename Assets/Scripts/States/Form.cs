using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Form : _State
{
    [SerializeField] private List<List<_State>> _type_states;
    [SerializeField] private List<List<_System>> _type_systems;

    // todo : indexing
    private bool isChange = false;

    public bool _type
    {
        get
        {
            return isChange;
        }
    }

    public void ChangeForm()
    {
        isChange = !isChange;
    }
}
