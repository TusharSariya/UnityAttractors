using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraOrbit : MonoBehaviour
{
    public Transform cameraPos;
    //rotate camerabox with respect to time
    private void Update()
    {
        cameraPos.localRotation = Quaternion.Euler(0f, Time.time * 24f, 0f);
    }
}
