using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    void Update()
    {
        Playable _playable = GetComponent<Playable>();
        
        Eye _eye = GetComponent<Eye>();

        Vector2 rotationVector = Vector2.zero;

        if (_playable)
        {
            rotationVector += _playable.mousePosition.normalized;
        }
        
        if (_eye && _eye.eyeType == Eye.EyeType.Rotate)
        {
            _eye.Move(rotationVector);
        }
    }
}
