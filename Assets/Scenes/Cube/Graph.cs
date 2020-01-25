using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    public Transform cubePrefab;

    private void Awake()
    {
        Vector3 Pos;
        Pos.y = 0f;
        Pos.z = 0f;
        for (int i = 0; i < 10; i++)
        {
            Transform point = Instantiate(cubePrefab);
            Pos.x = -5 + i;
            point.localPosition = Pos;
            point.SetParent(transform);
        }
        
    }
}
