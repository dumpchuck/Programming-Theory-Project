using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : RandomShape
{

    public void SpawnCube()
    {
        SpawnShape();
        Debug.Log("Spawn a cube, display new text. If applicable, override old text");
    }
}
