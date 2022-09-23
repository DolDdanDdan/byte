using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEnergy : MonoBehaviour
{
    private Text text;
    private GameObject showObject;

    void Start()
    {
        text = GetComponent<Text>();
        showObject = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Energy _energy = showObject.GetComponent<Energy>();

        if (_energy)
        {
            text.text = Mathf.FloorToInt(_energy.energy).ToString();
        } 
    }
}
