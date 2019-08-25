using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public static event Action<GameObject> OnCube;

    void Awake()
    {
        OnCube = delegate { };
    }

    private void OnTriggerEnter(Collider collider)
    {
        OnCube(this.gameObject);
    }
}
