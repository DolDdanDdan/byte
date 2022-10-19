using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private GameObject _healthBar;
    [SerializeField] private Slider slider;

    public void SetEnable(bool enable)
    {
        if (_healthBar)
        {
            _healthBar.SetActive(enable);
        }
        else
        {
            Debug.LogError("not having healthBar GameObject");
        }
    }
    public void SetValue(float value)
    {
        if (slider)
        {
            slider.value = value;
        }
        else
        {
            Debug.LogError("not having slider Slider");
        }
    }
}

