using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cube.OnCube += CubeEater_OnCube;
    }

    private void CubeEater_OnCube(GameObject gameObject)
    {
        Destroy(gameObject);
    }
}
