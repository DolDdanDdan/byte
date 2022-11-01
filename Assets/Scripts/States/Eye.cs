using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye : MonoBehaviour
{
    public enum EyeType
    {
        Move,
        Rotate
    }

    [SerializeField] private GameObject _eye;
    [SerializeField] private EyeType _eye_type;
    [SerializeField] private float _eye_distance;

    public EyeType eyeType
    {
        get
        {
            return _eye_type;
        }
    }

    public void Move(Vector2 position)
    {
        _eye.transform.localPosition = Vector2.Lerp(
            _eye.transform.localPosition,
            position.normalized * _eye_distance,
            0.5f
        );
    }
}
