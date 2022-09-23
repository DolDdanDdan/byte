using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour
{
    public float energy = 0.0f;

    public void addEnergy(float delta)
    {
        energy += delta;
    }
}
