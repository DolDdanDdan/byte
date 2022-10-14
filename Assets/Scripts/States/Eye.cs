using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye : MonoBehaviour
{
    public enum EyeType
    {
        Move
    }

    [SerializeField] private GameObject _eye;
    [SerializeField] private EyeType _eye_type;

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
            position.normalized * 0.1f,
            0.5f
        );
    }
}
