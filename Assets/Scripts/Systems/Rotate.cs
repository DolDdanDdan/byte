using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    void Update()
    {
        Playable _playable = GetComponent<Playable>();

        Target _target = GetComponent<Target>();
        
        Eye _eye = GetComponent<Eye>();

        Vector2 rotationVector = Vector2.zero;

        if (_playable)
        {
            rotationVector += _playable.mousePosition.normalized;
        }

        if (_target)
        {
            rotationVector += _target.moveVector;
        }
        
        if (_eye && _eye.eyeType == Eye.EyeType.Rotate)
        {
            _eye.Move(rotationVector.normalized);
        }
    }
}
