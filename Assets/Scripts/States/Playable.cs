using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Can be handling object's value
public class Playable : MonoBehaviour
{
    public Vector2 lastMoveVector = Vector2.zero;
    
    public Vector2 moveVector
    {
        get
        {
            Vector2 v = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            if (v != Vector2.zero)
            {
                lastMoveVector = v;
            }
            return v.normalized;
        }
    }

    // Object's Position is Vector2.zero
    public Vector2 mousePosition
    {
        get
        {
            Vector2 m = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            return m;
        }
    }

    public bool mouseClick
    {
        get { return false; }
    }

    public bool spaceKey
    {
        get { 
            return Input.GetKeyDown("space"); 
        }
    }
}
