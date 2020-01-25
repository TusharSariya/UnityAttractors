using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointGenerator : MonoBehaviour
{
    public Transform _point;
    public double x = 0.1;
    public double y = 0;
    public double z = 0;
    public double a = 10.0;
    public double b = 28.0;
    public double c = 8.0 / 3.0;
    public double t = 0.01;
    private void Awake()
    {
        //instantiate objects with offset for time
        //set color by position (or time?)
        Vector3 Pos;
        
        int lorenzIterationCount = 10000;
        int i;
        for (i = 0; i < lorenzIterationCount; i++)
        {
            Transform point = Instantiate(_point);
            double xt = x + t * a * (y - x);
            double yt = y + t * (x * (b - z) - y);
            double zt = z + t * (x * y - c * z);
            x = xt;
            y = yt;
            z = zt;
            Pos.x = (float)xt;
            Pos.y = (float)yt;
            Pos.z = (float)zt;
            Debug.Log(xt + " " + yt + " " + zt);
            point.localPosition = Pos;
            point.SetParent(transform);

        }
    }
}
