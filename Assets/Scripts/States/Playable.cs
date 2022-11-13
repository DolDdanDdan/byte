using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Can be handling object's value
public class Playable : _State
{
    private Vector2 _lastMoveVector = Vector2.zero;

    public Vector2 lastMoveVector
    {
        get
        {
            return _lastMoveVector;
        }
    }
    
    public Vector2 moveVector
    {
        get
        {
            Vector2 v = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            if (v != Vector2.zero)
            {
                _lastMoveVector = v.normalized;
            }
            return v.normalized;
        }
    }

    // Think of object's Position is Vector2.zero
    public Vector2 mousePosition
    {
        get
        {
            Vector2 m = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            return m;
        }
    }

    public bool mouseClick
    {
        get { 
            return Input.GetMouseButtonDown(0);
        }
    }

    public bool mouseRightClick
    {
        get
        {
            return Input.GetMouseButtonDown(2);
        }
    }

    public bool modeKey
    {
        get
        {
            return Input.GetKeyDown(KeyCode.Q);
        }
    }

    public bool skillKey
    {
        get
        {
            return Input.GetKeyDown(KeyCode.E);
        }
    }

    public bool skillChangeKey
    {
        get
        {
            return Input.GetKeyDown(KeyCode.R);
        }
    }

    public bool spaceKey
    {
        get { 
            return Input.GetKeyDown("space"); 
        }
    }
}
